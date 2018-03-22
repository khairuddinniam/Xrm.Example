using Microsoft.Xrm.Sdk;
using Niam.XRM.Framework;
using Niam.XRM.Framework.Data;
using Niam.XRM.Framework.Interfaces.Plugin;
using Niam.XRM.Framework.Interfaces.Plugin.Configurations;
using Niam.XRM.Framework.Plugin;
using Xrm.Example.CrmSvcUtilEarlyBound.Business.SalesOrderLine;

namespace Xrm.Example.CrmSvcUtilEarlyBound.Plugins
{
    // Registered on message: Create, Update, Delete
    public class PreSalesOrderLine : PluginBase<ins_salesorderline>, IPlugin
    {
        public PreSalesOrderLine(string unsecure, string secure) : base(unsecure, secure)
        {
        }

        public static void ConfigurePlugin(IPluginConfiguration<ins_salesorderline> config)
        {
            config.ColumnSet = new ColumnSet<ins_salesorderline>(
                e => e.ins_salesorderid,
                e => e.ins_productid,
                e => e.ins_priceamount,
                e => e.ins_qty
            );
        }

        protected override void Configure(IPluginConfiguration<ins_salesorderline> config)
        {
            base.Configure(config);
            ConfigurePlugin(config);
        }

        protected override void ExecuteCrmPlugin(IPluginContext<ins_salesorderline> context)
        {
            var messageName = context.PluginExecutionContext.MessageName;
            if (messageName == "Create" || messageName == "Update")
            {
                var target = context.Target;
                if (target.ContainsAny(e => e.ins_productid))
                {
                    new LoadProductData(context).Execute();
                }

                if (target.ContainsAny(e => e.ins_priceamount, e => e.ins_qty))
                {
                    new CalculateTotalPrice(context).Execute();
                }
            }

            if (messageName == "Delete")
            {
                new UpdateSalesOrder(context).Execute();
            }
        }
    }
}
