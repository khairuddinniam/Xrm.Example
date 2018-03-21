using Niam.XRM.Framework.Interfaces.Plugin;
using Niam.XRM.Framework.Plugin;

namespace Xrm.Example.CustomEarlyBound.Business.SalesOrderLine
{
    public class CalculateTotalPrice : OperationBase<ins_salesorderline>
    {
        public CalculateTotalPrice(ITransactionContext<ins_salesorderline> context) : base(context)
        {
        }

        protected override void HandleExecute()
        {
            var totalPrice = GetValue(e => e.ins_priceamount) * GetValue(e => e.ins_qty);
            Set(e => e.ins_totalprice, totalPrice);
        }
    }
}
