using System;
using Microsoft.Xrm.Sdk;
using Niam.XRM.TestFramework;
using Xrm.Example.CrmSvcUtilEarlyBound.Business.SalesOrderLine;
using Xrm.Example.CrmSvcUtilEarlyBound.Plugins;
using Xunit;

namespace Xrm.Example.CrmSvcUtilEarlyBound.Tests.Business.SalesOrderLine
{
    public class CalculateTotalPriceTests
    {
        [Fact]
        public void Can_calculate_total_price()
        {
            var id = Guid.NewGuid();
            var initial = new ins_salesorderline
            {
                Id = id,
                ins_qty = 5
            };

            var target = new ins_salesorderline
            {
                Id = id,
                ins_priceamount = new Money(200m)
            };

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

            Assert.Equal(1000m, target.ins_totalprice.Value);
        }
    }
}
