using System;
using System.Windows.Forms;

namespace CarRentalBusiness_FD_
{
    public partial class FrmHiringActivity : CarRentalBusiness_FD_.FrmActivity
    {
        public FrmHiringActivity()
        {
            InitializeComponent();
        }

        protected override void updateDisplay()
        {
            base.updateDisplay();
            ClsHiringActivity lcHiringActivity = (ClsHiringActivity)_Activity;
            dtpEndDate.Value = lcHiringActivity.EndDate;
            numInputAmount.Value = lcHiringActivity.CalcCashFlowAmount();
        }

        protected override void pushData()
        {
            base.pushData();
            ClsHiringActivity lcHiringActivity = (ClsHiringActivity)_Activity;
            lcHiringActivity.EndDate = dtpEndDate.Value;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dateValidation();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            dateValidation();
        }

        private void dateValidation()
        {
            DateTime StartDate = Convert.ToDateTime(dtpDate.Value);
            DateTime EndDate = Convert.ToDateTime(dtpEndDate.Value);
            if (StartDate > EndDate)
            {
                StartDate = EndDate;
                MessageBox.Show("Sorry but the start date can not be greater than the end date.");
                updateDisplay();
            }
            else
            {
                pushData();
                updateDisplay();
            }
        }
    }
}
