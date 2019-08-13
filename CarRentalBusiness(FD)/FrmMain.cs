using System;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalBusiness_FD_
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            try
            {
                ClsVehicleBusiness.Retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            updateDisplay();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            ClsVehicle lcVehicle = new ClsVehicle();
            if (lcVehicle != null && lcVehicle.ViewEdit())
            {
                ClsVehicleBusiness.VehicleList.Add(lcVehicle.RegistrationNo, lcVehicle);
                updateDisplay();
            }
        }

        private void btnModifyVehicle_Click(object sender, EventArgs e)
        {
            editVehicle();
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this vehicle?", "Remove Vehicle", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ClsVehicle lcVehicle = (ClsVehicle)lstLicencePlates.SelectedItem;
                ClsVehicleBusiness.VehicleList.Remove(lcVehicle.RegistrationNo);
                updateDisplay();
            }
            else
            {
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                ClsVehicleBusiness.Save();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            Close();
        }

        private void lstLicencePlates_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editVehicle();
        }
        private void lstLicencePlates_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lcSelectedRegistrationNo = lstLicencePlates.Text;

            foreach (ClsVehicle lcItem in ClsVehicleBusiness.VehicleList.Values)
            {
                if (lcItem.RegistrationNo == lcSelectedRegistrationNo)
                {
                    lblQuickView.Text = lcItem.ToStringQuickView();
                }
            }
        }

        private void updateDisplay()
        {
            lblTotalCashflowAmount.Text = string.Format("{1:C}", ClsVehicleBusiness.VehicleList.Count, ClsVehicleBusiness.TotalCashflow());
            lstLicencePlates.DataSource = null;
            lstLicencePlates.DataSource = ClsVehicleBusiness.VehicleList.Values.ToList<ClsVehicle>();
        }

        private void editVehicle()
        {
            ClsVehicle lcVehicle = (ClsVehicle)lstLicencePlates.SelectedItem;
            if (lcVehicle != null && lcVehicle.ViewEdit())
            {
                updateDisplay();
            }
        }
    }
}
