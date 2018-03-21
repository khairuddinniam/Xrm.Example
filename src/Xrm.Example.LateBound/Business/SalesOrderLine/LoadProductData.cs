using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Niam.XRM.Framework.Interfaces.Plugin;
using Niam.XRM.Framework.Plugin;

namespace Xrm.Example.LateBound.Business.SalesOrderLine
{
    public class LoadProductData : OperationBase
    {
        public LoadProductData(ITransactionContext<Entity> context) : base(context)
        {
        }

        protected override void HandleExecute()
        {
            var productColumnSet = new ColumnSet("name", "price");
            var product = GetRelated("ins_productid", productColumnSet);

            Set("ins_linenumber", product.Get<string>("name"));
            Set("ins_priceamount", product.Get<Money>("price"));
        }
    }
}
