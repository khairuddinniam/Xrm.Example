using System;
using Niam.XRM.Framework;
using Niam.XRM.TestFramework;
using Xrm.Example.CustomEarlyBound.Business.SalesOrderLine;
using Xrm.Example.CustomEarlyBound.Plugins;
using Xunit;

namespace Xrm.Example.CustomEarlyBound.Tests.Business.SalesOrderLine
{
    public class CalculateTotalPriceTests
    {
        [Fact]
        public void Can_calculate_total_price()
        {
            var id = Guid.NewGuid();
            var initial = new ins_salesorderline
            {
                Id = id
            };
            initial.Set(e => e.ins_qty, 5);

            var target = new ins_salesorderline
            {
                Id = id
            };
            target.Set(e => e.ins_priceamount, 200m);

            var testEvent = new TestEvent<ins_salesorderline>
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

            Assert.Equal(1000m, target.Get(e => e.ins_totalprice).Value);
        }
    }
}
