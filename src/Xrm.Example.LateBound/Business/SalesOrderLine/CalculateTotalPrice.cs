using Microsoft.Xrm.Sdk;
using Niam.XRM.Framework;
using Niam.XRM.Framework.Interfaces.Plugin;
using Niam.XRM.Framework.Plugin;

namespace Xrm.Example.LateBound.Business.SalesOrderLine
{
    public class CalculateTotalPrice : OperationBase
    {
        public CalculateTotalPrice(ITransactionContext<Entity> context) : base(context)
        {
        }

        protected override void HandleExecute()
        {
            var totalPrice = Get<Money>("ins_priceamount").GetValueOrDefault() * 
                             Get<int?>("ins_qty").GetValueOrDefault();
            Set("ins_totalprice", new Money(totalPrice));
        }
    }
}
