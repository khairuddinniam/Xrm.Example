using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Niam.XRM.Framework;
using Niam.XRM.Framework.Data;
using Niam.XRM.Framework.Interfaces.Plugin;
using Niam.XRM.Framework.Interfaces.Plugin.Configurations;
using Niam.XRM.Framework.Plugin;
using Xrm.Example.LateBound.Business.SalesOrderLine;

namespace Xrm.Example.LateBound.Plugins
{
    public class PostSalesOrderLine : PluginBase, IPlugin
    {
        public PostSalesOrderLine(string unsecure, string secure) : base(unsecure, secure)
        {
        }

        public static void ConfigurePlugin(IPluginConfiguration<Entity> config)
        {
            config.ColumnSet = new ColumnSet(
                "ins_salesorderid",
                "ins_totalprice"
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
                if (target.ContainsAny("ins_totalprice"))
                {
                    new CalculateTotalPrice(context).Execute();
                }
            }
        }
    }
}
