using System;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Niam.XRM.Framework;
using Niam.XRM.Framework.Interfaces.Plugin;
using Niam.XRM.Framework.Plugin;

namespace Xrm.Example.CustomEarlyBound.Business.SalesOrderLine
{
    public class UpdateSalesOrder : OperationBase<ins_salesorderline>
    {
        public UpdateSalesOrder(ITransactionContext<ins_salesorderline> context) : base(context)
        {
        }

        protected override void HandleExecute()
        {
            var salesOrderRef = Get(e => e.ins_salesorderid);
            if (salesOrderRef == null) return;

            var lineTotalPriceSum = GetLineTotalPriceSum(salesOrderRef.Id);
            var salesOrder = new ins_salesorder
            {
                Id = salesOrderRef.Id
            };
            salesOrder.Set(e => e.ins_totalprice, lineTotalPriceSum);
            Service.Update(salesOrder);
        }

        private decimal GetLineTotalPriceSum(Guid salesOrderId)
        {
            var excludeSelfCondition = Context.PluginExecutionContext.MessageName == "Delete"
                ? $"<condition attribute='{Name(e => e.Id)}' operator='ne' value='{Id}' />"
                : "";

            var fetchXml = String.Join("",
                "<fetch mapping='logical' aggregate='true'>",
                    $"<entity name='{EntityName}'>",
                        $"<attribute name='{Name(e => e.ins_totalprice)}' aggregate='sum' alias='sum_totalprice' />",
                        "<filter type='and'>",
                            $"<condition attribute='{Name(e => e.ins_salesorderid)}' operator='eq' value='{salesOrderId}' />",
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
