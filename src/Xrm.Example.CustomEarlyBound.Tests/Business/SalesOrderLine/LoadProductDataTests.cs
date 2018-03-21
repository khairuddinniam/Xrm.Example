using System;
using Niam.XRM.Framework;
using Niam.XRM.TestFramework;
using Xrm.Example.CustomEarlyBound.Business.SalesOrderLine;
using Xrm.Example.CustomEarlyBound.Plugins;
using Xunit;

namespace Xrm.Example.CustomEarlyBound.Tests.Business.SalesOrderLine
{
    public class LoadProductDataTests
    {
        [Fact]
        public void Can_load_product_data()
        {
            var product = new Product
            {
                Id = Guid.NewGuid()
            };
            product.Set(e => e.Name, "Product ABC");
            product.Set(e => e.Price, 2500m);

            var id = Guid.NewGuid();
            var initial = new ins_salesorderline
            {
                Id = id
            };

            var target = new ins_salesorderline
            {
                Id = id
            };
            target.Set(e => e.ins_productid, product.ToEntityReference());

            var testEvent = new TestEvent<ins_salesorderline>
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

            Assert.Equal("Product ABC", target.Get(e => e.ins_linenumber));
            Assert.Equal(2500m, target.Get(e => e.ins_priceamount).Value);
        }
    }
}
