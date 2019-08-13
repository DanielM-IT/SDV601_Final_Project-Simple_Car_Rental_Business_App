using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRentalBusiness_FD_
{
    public partial class FrmActivityLog : Form
    {
        private ClsVehicle _Vehicle;
        private IComparer<ClsActivity>[] _Comparer = { new ClsNameComparer(), new ClsDateComparer() };
        private readonly string[] _SortStrings = { "Name", "Date" };

        class ClsNameComparer : IComparer<ClsActivity>
        {
            public int Compare(ClsActivity prActivityX, ClsActivity prActivityY)
            {
                int lcResult = prActivityX.Name.CompareTo(prActivityY.Name);
                if (lcResult != 0)
                    return lcResult;
                else
                    return prActivityX.ActivityDate.Date.CompareTo(prActivityY.ActivityDate.Date);
            }
        }

        class ClsDateComparer : IComparer<ClsActivity>
        {
            public int Compare(ClsActivity prActivityX, ClsActivity prActivityY)
            {
                int lcResult = prActivityX.ActivityDate.Date.CompareTo(prActivityY.ActivityDate.Date);
                if (lcResult != 0)
                    return lcResult;
                else
                    return prActivityX.Name.CompareTo(prActivityY.Name);
            }
        }

        public FrmActivityLog(ClsVehicle prVehicle)
        {
            InitializeComponent();
            cboActivitySelection.DataSource = ClsActivity.ActivityType;
            cboListSorter.DataSource = _SortStrings;
            cboActivitySelection.SelectedIndex = 0;
            _Vehicle = prVehicle;
        }

        private void FrmActivityLog_Load(object sender, EventArgs e)
        {
            lblVehicleID.Text = _Vehicle.RegistrationNo;
            updateActivityList();
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            ClsActivity lcActivity = ClsActivity.NewActivity(cboActivitySelection.SelectedIndex, _Vehicle);
            if (lcActivity != null && lcActivity.ViewEdit())
            {
                _Vehicle.ActivityList.Add(lcActivity);
                updateActivityList();
            }
        }

        private void btnFindActivity_Click(object sender, EventArgs e)
        {
            for (int i = lstActivityLog.Items.Count - 1; i >= 0; i--)
            {
                if (lstActivityLog.Items[i].ToString().ToLower().Contains(txtFindActivity.Text.ToLower()))
                {
                    lstActivityLog.SetSelected(i, true);
                }
            }
        }

        private void btnEditActivity_Click(object sender, EventArgs e)
        {
            editActivity();
            updateActivityList();
        }

        private void btnDeleteActivity_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this activity?", "Remove Activity", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ClsActivity lcActivity = (ClsActivity)lstActivityLog.SelectedItem;
                _Vehicle.ActivityList.Remove(lcActivity);
                updateActivityList();
            }
            else
            {
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstActivityLog_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editActivity();
        }

        private void cbListSorter_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateActivityList();
        }

        private void editActivity()
        {
            ClsActivity lcActivity = (ClsActivity)lstActivityLog.SelectedItem;
            if (lcActivity != null && lcActivity.ViewEdit())
            {
                updateActivityList();
            }
        }

        public void updateActivityList()
        {
            try
            {
                List<ClsActivity> lcListOfActivities = _Vehicle.ActivityList;
                lcListOfActivities.Sort(_Comparer[cboListSorter.SelectedIndex]);
                lstActivityLog.DataSource = null;
                lstActivityLog.DataSource = lcListOfActivities;
                txtTotalVehicleCashflow.Text = string.Format("{1:C}", _Vehicle.ActivityList.Count, _Vehicle.TotalVehicleCashflow());
            }
            catch
            {

            }
        }
    }
}
