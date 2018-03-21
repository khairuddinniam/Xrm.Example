using System;
using Microsoft.Xrm.Sdk;
using Niam.XRM.Framework;
using Niam.XRM.TestFramework;
using Xrm.Example.LateBound.Business.SalesOrderLine;
using Xrm.Example.LateBound.Plugins;
using Xunit;

namespace Xrm.Example.LateBound.Tests.Business.SalesOrderLine
{
    public class LoadProductDataTests
    {
        [Fact]
        public void Can_load_product_data()
        {
            var product = new Entity("product")
            {
                Id = Guid.NewGuid()
            };
            product.Set("name", "Product ABC");
            product.Set("price", new Money(2500m));

            var id = Guid.NewGuid();
            var initial = new Entity("ins_salesorderline")
            {
                Id = id
            };

            var target = new Entity("ins_salesorderline")
            {
                Id = id
            };
            target.Set("ins_productid", product.ToEntityReference());

            var testEvent = new TestEvent
            {
                Plugin =
                {
                    Configure = PreSalesOrderLine.ConfigurePlugin
                },
                Db = { initial, product }
            };
            testEvent.ForUpdate(target);

            var context = testEvent.CreatePluginContext();
            new LoadProductData(context).Execute();

            Assert.Equal("Product ABC", target.Get<string>("ins_linenumber"));
            Assert.Equal(2500m, target.Get<Money>("ins_priceamount").Value);
        }
    }
}
