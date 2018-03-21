using Niam.XRM.Framework;
using Niam.XRM.Framework.Data;
using Niam.XRM.Framework.Interfaces.Plugin;
using Niam.XRM.Framework.Plugin;

namespace Xrm.Example.CustomEarlyBound.Business.SalesOrderLine
{
    public class LoadProductDataUsingExtensions : OperationBase<ins_salesorderline>
    {
        public LoadProductDataUsingExtensions(ITransactionContext<ins_salesorderline> context) : base(context)
        {
        }

        protected override void HandleExecute()
        {
            var productColumnSet = new ColumnSet<Product>(e => e.Name, e => e.Price);
            var product = this.GetProduct(productColumnSet);

            Set(e => e.ins_linenumber, product.Get(e => e.Name));
            Set(e => e.ins_priceamount, product.Get(e => e.Price));
        }
    }
}
