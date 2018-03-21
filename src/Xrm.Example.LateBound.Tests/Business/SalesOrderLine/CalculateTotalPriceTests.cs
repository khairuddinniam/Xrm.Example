using System;
using Microsoft.Xrm.Sdk;
using Niam.XRM.Framework;
using Niam.XRM.TestFramework;
using Xrm.Example.LateBound.Business.SalesOrderLine;
using Xrm.Example.LateBound.Plugins;
using Xunit;

namespace Xrm.Example.LateBound.Tests.Business.SalesOrderLine
{
    public class CalculateTotalPriceTests
    {
        [Fact]
        public void Can_calculate_total_price()
        {
            var id = Guid.NewGuid();
            var initial = new Entity("ins_salesorderline")
            {
                Id = id
            };
            initial.Set("ins_qty", 5);

            var target = new Entity("ins_salesorderline")
            {
                Id = id
            };
            target.Set("ins_priceamount", new Money(200m));

            var testEvent = new TestEvent
            {
                Plugin =
                {
                    Configure = PreSalesOrderLine.ConfigurePlugin
                },
                Db = { initial }
            };
            testEvent.ForUpdate(target);

            var context = testEvent.CreatePluginContext();
            new CalculateTotalPrice(context).Execute();

            Assert.Equal(1000m, target.Get<Money>("ins_totalprice").Value);
        }
    }
}
