using Microsoft.Xrm.Sdk;
using Niam.XRM.Framework;
using Niam.XRM.Framework.Interfaces.Plugin;
using Niam.XRM.Framework.Plugin;

namespace Xrm.Example.CrmSvcUtilEarlyBound.Business.SalesOrderLine
{
    public class CalculateTotalPrice : OperationBase<ins_salesorderline>
    {
        public CalculateTotalPrice(ITransactionContext<ins_salesorderline> context) : base(context)
        {
        }

        protected override void HandleExecute()
        {
            // You can do this,
            //
            //var totalPrice = GetValue(e => e.ins_priceamount) * GetValue(e => e.ins_qty);
            //Set(e => e.ins_totalprice, totalPrice);
            //
            // or:
            var src = Wrapper.Entity;
            var set = Context.Target.Entity;
            var totalPrice = src.ins_priceamount.GetValueOrDefault() *
                             src.ins_qty.GetValueOrDefault();
            set.ins_totalprice = new Money(totalPrice);
        }
    }
}
