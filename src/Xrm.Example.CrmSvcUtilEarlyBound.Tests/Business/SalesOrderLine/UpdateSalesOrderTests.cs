using System;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Niam.XRM.Framework;
using Niam.XRM.TestFramework;
using Xrm.Example.CrmSvcUtilEarlyBound.Business.SalesOrderLine;
using Xrm.Example.CrmSvcUtilEarlyBound.Plugins;
using Xunit;

namespace Xrm.Example.CrmSvcUtilEarlyBound.Tests.Business.SalesOrderLine
{
    public class UpdateSalesOrderTests
    {
        [Fact]
        public void Can_update_sales_order_on_post()
        {
            var salesOrder = new ins_salesorder
            {
                Id = Guid.NewGuid()
            };

            var line = new ins_salesorderline
            {
                Id = Guid.NewGuid(),
                ins_salesorderid = salesOrder.ToEntityReference(),
                ins_totalprice = new Money(1000m)
            };

            var unrelatedLine = new ins_salesorderline
            {
                Id = Guid.NewGuid(),
                ins_salesorderid = new EntityReference(ins_salesorder.EntityLogicalName, Guid.NewGuid()),
                ins_totalprice = new Money(7000m)
            };

            var id = Guid.NewGuid();
            var initial = new ins_salesorderline
            {
                Id = id,
                ins_salesorderid = salesOrder.ToEntityReference(),
                ins_totalprice = new Money(500m)
            };

            var target = new ins_salesorderline
            {
                Id = id,
                ins_totalprice = new Money(500m)
            };

            var testEvent = new TestEvent<ins_salesorderline>
            {
                Plugin =
                {
                    Configure = PostSalesOrderLine.ConfigurePlugin
                },
                Db = { initial, line, unrelatedLine, salesOrder }
            };
            testEvent.ForUpdate(target, 40);

            var context = testEvent.CreatePluginContext();
            new UpdateSalesOrder(context).Execute();

            var updateSalesOrder = testEvent.FakedContext
                .CreateQuery<ins_salesorder>()
                .First();

            Assert.Equal(1500m, updateSalesOrder.ins_totalprice.Value);
        }

        [Fact]
        public void Can_update_sales_order_on_delete()
        {
            var salesOrder = new ins_salesorder
            {
                Id = Guid.NewGuid()
            };

            var line = new ins_salesorderline
            {
                Id = Guid.NewGuid(),
                ins_salesorderid = salesOrder.ToEntityReference(),
                ins_totalprice = new Money(1000m)
            };

            var unrelatedLine = new ins_salesorderline
            {
                Id = Guid.NewGuid(),
                ins_salesorderid = new EntityReference(ins_salesorder.EntityLogicalName, Guid.NewGuid()),
                ins_totalprice = new Money(7000m)
            };

            var id = Guid.NewGuid();
            var initial = new ins_salesorderline
            {
                Id = id,
                ins_salesorderid = salesOrder.ToEntityReference(),
                ins_totalprice = new Money(500m)
            };

            var target = new ins_salesorderline
            {
                Id = id
            };

            var testEvent = new TestEvent<ins_salesorderline>
            {
                Plugin =
                {
                    Configure = PreSalesOrderLine.ConfigurePlugin
                },
                Db = { initial, line, unrelatedLine, salesOrder }
            };
            testEvent.ForDelete(target.ToEntityReference());

            var context = testEvent.CreatePluginContext();
            new UpdateSalesOrder(context).Execute();

            var updateSalesOrder = testEvent.FakedContext
                .CreateQuery<ins_salesorder>()
                .First();

            Assert.Equal(1000m, updateSalesOrder.ins_totalprice.Value);
        }
    }
}
