using System;

namespace CarRentalBusiness_FD_
{
    [Serializable]
    public class ClsServiceActivity : ClsActivity
    {
        private static FrmServiceActivity _ServiceForm = new FrmServiceActivity();

        private string _Description;

        public string Description
        {
            get => _Description;
            set => _Description = value;
        }

        public override bool ViewEdit()
        {
            return _ServiceForm.ShowDialog(this);
        }

        protected override string typeOfActivity()
        {
            return "Service";
        }

        public override decimal CalcCashFlowAmount()
        {
            return -InputAmount;
        }
    }
}
