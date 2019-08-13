using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalBusiness_FD_
{
    public partial class FrmVehicle : Form
    {
        private ClsVehicle _Vehicle;
        private FrmActivityLog _ActivityLog;
        private decimal lcDailyHire;

        public FrmVehicle()
        {
            InitializeComponent();
        }

        private void FrmVehicle_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtRegistrationNo.Text))
            {
                btnActivityLog.Enabled = false;
                numYear.Value = 2000;
                numDailyHire.Value = 10;
            }
            else
            {
                btnActivityLog.Enabled = true;
                lcDailyHire = numDailyHire.Value;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtRegistrationNo.Enabled && ClsVehicleBusiness.VehicleList.ContainsKey(txtRegistrationNo.Text))
                MessageBox.Show("Vehicle with that registration number already exists", "Duplicate Registration Number");

            else
            {
                if (string.IsNullOrWhiteSpace(txtRegistrationNo.Text) || string.IsNullOrWhiteSpace(txtMake.Text) || string.IsNullOrWhiteSpace(txtModel.Text))
                {
                    MessageBox.Show("Please fill out all fields.", "Empty Fields");
                }
                else
                {
                    pushData();
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            numDailyHire.Value = lcDailyHire;
            this.Close();
        }

        private void btnActivityLog_Click(object sender, EventArgs e)
        {
            _ActivityLog = new FrmActivityLog(_Vehicle);
            _ActivityLog.ShowDialog();
        }

        private void txtRegistrationNo_TextChanged(object sender, EventArgs e)
        {
            txtRegistrationNo.Text = string.Concat(txtRegistrationNo.Text.Where(char.IsLetterOrDigit));
        }

        private void numDailyHire_ValueChanged(object sender, EventArgs e)
        {
            pushData();
        }

        public bool ShowDialog(ClsVehicle prVehicle)
        {
            _Vehicle = prVehicle;
            updateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        private void updateDisplay()
        {
            txtRegistrationNo.Text = _Vehicle.RegistrationNo;
            txtMake.Text = _Vehicle.Make;
            txtModel.Text = _Vehicle.Model;
            numYear.Value = Convert.ToInt32(_Vehicle.Year);
            numDailyHire.Value = _Vehicle.DailyHire;
            txtRegistrationNo.Enabled = String.IsNullOrEmpty(_Vehicle.RegistrationNo);
        }

        private void pushData()
        {
            _Vehicle.RegistrationNo = txtRegistrationNo.Text;
            _Vehicle.Make = txtMake.Text;
            _Vehicle.Model = txtModel.Text;
            _Vehicle.Year = Convert.ToDecimal(numYear.Value);
            _Vehicle.DailyHire = numDailyHire.Value;
        }
    }
}
