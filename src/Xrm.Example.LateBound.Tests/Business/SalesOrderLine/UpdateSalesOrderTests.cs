using System;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Niam.XRM.Framework;
using Niam.XRM.TestFramework;
using Xrm.Example.LateBound.Business.SalesOrderLine;
using Xrm.Example.LateBound.Plugins;
using Xunit;

namespace Xrm.Example.LateBound.Tests.Business.SalesOrderLine
{
    public class UpdateSalesOrderTests
    {
        [Fact]
        public void Can_update_sales_order_on_post()
        {
            var salesOrder = new Entity("ins_salesorder")
            {
                Id = Guid.NewGuid()
            };

            var line = new Entity("ins_salesorderline")
            {
                Id = Guid.NewGuid()
            };
            line.Set("ins_salesorderid", salesOrder.ToEntityReference());
            line.Set("ins_totalprice", new Money(1000m));

            var unrelatedLine = new Entity("ins_salesorderline")
            {
                Id = Guid.NewGuid()
            };
            unrelatedLine.Set("ins_salesorderid", new EntityReference("ins_salesorder", Guid.NewGuid()));
            unrelatedLine.Set("ins_totalprice", new Money(7000m));

            var id = Guid.NewGuid();
            var initial = new Entity("ins_salesorderline")
            {
                Id = id
            };
            initial.Set("ins_salesorderid", salesOrder.ToEntityReference());
            initial.Set("ins_totalprice", new Money(500m));

            var target = new Entity("ins_salesorderline")
            {
                Id = id
            };
            target.Set("ins_totalprice", new Money(500m));

            var testEvent = new TestEvent
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
                .CreateQuery("ins_salesorder")
                .First();

            Assert.Equal(1500m, updateSalesOrder.Get<Money>("ins_totalprice").Value);
        }

        [Fact]
        public void Can_update_sales_order_on_delete()
        {
            var salesOrder = new Entity("ins_salesorder")
            {
                Id = Guid.NewGuid()
            };

            var line = new Entity("ins_salesorderline")
            {
                Id = Guid.NewGuid()
            };
            line.Set("ins_salesorderid", salesOrder.ToEntityReference());
            line.Set("ins_totalprice", new Money(1000m));

            var unrelatedLine = new Entity("ins_salesorderline")
            {
                Id = Guid.NewGuid()
            };
            unrelatedLine.Set("ins_salesorderid", new EntityReference("ins_salesorder", Guid.NewGuid()));
            unrelatedLine.Set("ins_totalprice", new Money(7000m));

            var id = Guid.NewGuid();
            var initial = new Entity("ins_salesorderline")
            {
                Id = id
            };
            initial.Set("ins_salesorderid", salesOrder.ToEntityReference());
            initial.Set("ins_totalprice", new Money(500m));

            var target = new Entity("ins_salesorderline")
            {
                Id = id
            };

            var testEvent = new TestEvent
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
                .CreateQuery("ins_salesorder")
                .First();

            Assert.Equal(1000m, updateSalesOrder.Get<Money>("ins_totalprice").Value);
        }
    }
}
