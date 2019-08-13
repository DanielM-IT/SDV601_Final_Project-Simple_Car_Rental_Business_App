using System;

namespace CarRentalBusiness_FD_
{
    public partial class FrmServiceActivity : CarRentalBusiness_FD_.FrmActivity
    {
        public FrmServiceActivity()
        {
            InitializeComponent();
        }

        private void FrmServiceActivity_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                numInputAmount.Value = 10;
            }
        }

        protected override void updateDisplay()
        {
            base.updateDisplay();
            ClsServiceActivity lcServiceActivity = (ClsServiceActivity)_Activity;
            txtDescription.Text = lcServiceActivity.Description;
        }

        protected override void pushData()
        {
            base.pushData();
            ClsServiceActivity lcServiceActivity = (ClsServiceActivity)_Activity;
            lcServiceActivity.Description = txtDescription.Text;
        }
    }
}
