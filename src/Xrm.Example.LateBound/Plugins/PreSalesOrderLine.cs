using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Niam.XRM.Framework;
using Niam.XRM.Framework.Interfaces.Plugin;
using Niam.XRM.Framework.Interfaces.Plugin.Configurations;
using Niam.XRM.Framework.Plugin;
using Xrm.Example.LateBound.Business.SalesOrderLine;

namespace Xrm.Example.LateBound.Plugins
{
    // Registered on message: Create, Update, Delete
    public class PreSalesOrderLine : PluginBase, IPlugin
    {
        public PreSalesOrderLine(string unsecure, string secure) : base(unsecure, secure)
        {
        }

        public static void ConfigurePlugin(IPluginConfiguration<Entity> config)
        {
            config.ColumnSet = new ColumnSet(
                "ins_salesorderid",
                "ins_productid",
                "ins_priceamount",
                "ins_qty"
            );
        }

        protected override void Configure(IPluginConfiguration<Entity> config)
        {
            base.Configure(config);
            ConfigurePlugin(config);
        }

        protected override void ExecuteCrmPlugin(IPluginContext<Entity> context)
        {
            var messageName = context.PluginExecutionContext.MessageName;
            if (messageName == "Create" || messageName == "Update")
            {
                var target = context.Target;
                if (target.ContainsAny("ins_productid"))
                {
                    new LoadProductData(context).Execute();
                }

                if (target.ContainsAny("ins_priceamount", "ins_qty"))
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
