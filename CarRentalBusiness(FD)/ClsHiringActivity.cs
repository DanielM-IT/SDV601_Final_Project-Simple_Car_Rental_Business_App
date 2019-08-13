using System;

namespace CarRentalBusiness_FD_
{
    [Serializable]
    public class ClsHiringActivity : ClsActivity
    {
        private static FrmHiringActivity _HiringForm = new FrmHiringActivity();

        private DateTime _EndDate = DateTime.Today;

        public DateTime EndDate
        {
            get => _EndDate;
            set => _EndDate = value;
        }

        public override bool ViewEdit()
        {
            return _HiringForm.ShowDialog(this);
        }

        protected override string typeOfActivity()
        {
            return "Hiring";
        }

        public override decimal CalcCashFlowAmount()
        {
            decimal lcDailyHireAmount = _Vehicle.DailyHire;            
            decimal lcTotalDays = Convert.ToDecimal((EndDate.Date - ActivityDate.Date).TotalDays);
            return  InputAmount = ((lcTotalDays + 1) * lcDailyHireAmount);
        }
    }
}
