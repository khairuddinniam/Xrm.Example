using System;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Niam.XRM.Framework;
using Niam.XRM.Framework.Interfaces.Plugin;
using Niam.XRM.Framework.Plugin;

namespace Xrm.Example.LateBound.Business.SalesOrderLine
{
    public class UpdateSalesOrder : OperationBase
    {
        public UpdateSalesOrder(ITransactionContext<Entity> context) : base(context)
        {
        }

        protected override void HandleExecute()
        {
            var salesOrderRef = Get<EntityReference>("ins_salesorderid");
            if (salesOrderRef == null) return;

            var lineTotalPriceSum = GetLineTotalPriceSum(salesOrderRef.Id);
            var salesOrder = new Entity("ins_salesorder")
            {
                Id = salesOrderRef.Id
            };
            salesOrder.Set("ins_totalprice", new Money(lineTotalPriceSum));
            Service.Update(salesOrder);
        }

        private decimal GetLineTotalPriceSum(Guid salesOrderId)
        {
            var excludeSelfCondition = Context.PluginExecutionContext.MessageName == "Delete"
                ? $"<condition attribute='ins_salesorderlineid' operator='ne' value='{Id}' />"
                : "";

            var fetchXml = String.Join("",
                "<fetch mapping='logical' aggregate='true'>",
                    "<entity name='ins_salesorderline'>",
                        "<attribute name='ins_totalprice' aggregate='sum' alias='sum_totalprice' />",
                        "<filter type='and'>",
                            $"<condition attribute='ins_salesorderid' operator='eq' value='{salesOrderId}' />",
                            excludeSelfCondition,
                        "</filter>",
                    "</entity>",
                "</fetch>"
            );

            var result = Service.RetrieveMultiple(fetchXml).Entities.FirstOrDefault();
            if (result == null) return 0m;

            return result.GetAliasedValue<Money>("sum_totalprice").GetValueOrDefault();
        }
    }
}
