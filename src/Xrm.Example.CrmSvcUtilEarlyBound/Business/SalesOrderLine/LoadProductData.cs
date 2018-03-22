using Niam.XRM.Framework.Data;
using Niam.XRM.Framework.Interfaces.Plugin;
using Niam.XRM.Framework.Plugin;

namespace Xrm.Example.CrmSvcUtilEarlyBound.Business.SalesOrderLine
{
    public class LoadProductData : OperationBase<ins_salesorderline>
    {
        public LoadProductData(ITransactionContext<ins_salesorderline> context) : base(context)
        {
        }

        protected override void HandleExecute()
        {
            var productColumnSet = new ColumnSet<Product>(e => e.Name, e => e.Price);
            var product = GetRelated<Product>(e => e.ins_productid, productColumnSet);

            // You can do this,
            //
            //Set(e => e.ins_linenumber, product.Get(e => e.Name));
            //Set(e => e.ins_priceamount, product.Get(e => e.Price));
            //
            // or:
            var set = Context.Target.Entity;
            set.ins_linenumber = product.Entity.Name;
            set.ins_priceamount = product.Entity.Price;
        }
    }
}
