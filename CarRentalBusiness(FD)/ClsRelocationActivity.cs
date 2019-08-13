using System;

namespace CarRentalBusiness_FD_
{
    [Serializable]
    public class ClsRelocationActivity : ClsActivity
    {
        private static FrmRelocationActivity _RelocationForm = new FrmRelocationActivity();

        private decimal _Kilometres;

        public decimal Kilometres
        {
            get => _Kilometres;
            set => _Kilometres = value;
        }

        public override bool ViewEdit()
        {
            return _RelocationForm.ShowDialog(this);
        }

        protected override string typeOfActivity()
        {
            return "Relocation";
        }

        public override decimal CalcCashFlowAmount()
        {
            return -InputAmount;
        }
    }
}
