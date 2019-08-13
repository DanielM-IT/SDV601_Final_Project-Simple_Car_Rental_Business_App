using System;
using System.Windows.Forms;

namespace CarRentalBusiness_FD_
{
    public partial class FrmActivity : Form
    {
        protected ClsActivity _Activity;

        public FrmActivity()
        {
            InitializeComponent();
            dtpDate.MaxDate = DateTime.Today;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Empty Fields");
            }
            else
            {
                pushData();
                DialogResult = DialogResult.OK;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ShowDialog(ClsActivity prActivity)
        {
            _Activity = prActivity;
            updateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        protected virtual void updateDisplay()
        {
            txtName.Text = _Activity.Name;
            numInputAmount.Value = _Activity.InputAmount;
            dtpDate.Value = _Activity.ActivityDate;
        }

        protected virtual void pushData()
        {
            _Activity.Name = txtName.Text;
            _Activity.InputAmount = numInputAmount.Value;
            _Activity.ActivityDate = dtpDate.Value;
        }
    }
}
