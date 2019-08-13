using System;

namespace CarRentalBusiness_FD_
{
    public partial class FrmRelocationActivity : CarRentalBusiness_FD_.FrmActivity
    {
        public FrmRelocationActivity()
        {
            InitializeComponent();
        }

        private void FrmRelocationActivity_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                numInputAmount.Value = 10;
                numKilometres.Value = 10;
            }
        }

        protected override void updateDisplay()
        {
            base.updateDisplay();
            ClsRelocationActivity lcRelocationActivity = (ClsRelocationActivity)_Activity;
            numKilometres.Value = lcRelocationActivity.Kilometres;
        }

        protected override void pushData()
        {
            base.pushData();
            ClsRelocationActivity lcRelocationActivity = (ClsRelocationActivity)_Activity;
            lcRelocationActivity.Kilometres = numKilometres.Value;
        }
    }
}
