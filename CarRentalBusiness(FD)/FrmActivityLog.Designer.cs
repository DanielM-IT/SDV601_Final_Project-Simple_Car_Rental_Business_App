namespace CarRentalBusiness_FD_
{
    partial class FrmActivityLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFindActivity = new System.Windows.Forms.TextBox();
            this.btnFindActivity = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalVehicalCashflow = new System.Windows.Forms.Label();
            this.cboActivitySelection = new System.Windows.Forms.ComboBox();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.btnDeleteActivity = new System.Windows.Forms.Button();
            this.btnEditActivity = new System.Windows.Forms.Button();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.txtTotalVehicleCashflow = new System.Windows.Forms.TextBox();
            this.lstActivityLog = new System.Windows.Forms.ListBox();
            this.cboListSorter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFindActivity
            // 
            this.txtFindActivity.Location = new System.Drawing.Point(206, 471);
            this.txtFindActivity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFindActivity.Name = "txtFindActivity";
            this.txtFindActivity.Size = new System.Drawing.Size(175, 26);
            this.txtFindActivity.TabIndex = 62;
            // 
            // btnFindActivity
            // 
            this.btnFindActivity.BackColor = System.Drawing.Color.LightGray;
            this.btnFindActivity.Location = new System.Drawing.Point(66, 466);
            this.btnFindActivity.Name = "btnFindActivity";
            this.btnFindActivity.Size = new System.Drawing.Size(134, 38);
            this.btnFindActivity.TabIndex = 61;
            this.btnFindActivity.Text = "Find Activity";
            this.btnFindActivity.UseVisualStyleBackColor = false;
            this.btnFindActivity.Click += new System.EventHandler(this.btnFindActivity_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(564, 109);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 25);
            this.lblDate.TabIndex = 60;
            this.lblDate.Text = "Date";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(226, 109);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 25);
            this.lblName.TabIndex = 59;
            this.lblName.Text = "Name";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(395, 109);
            this.lblCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(57, 25);
            this.lblCost.TabIndex = 58;
            this.lblCost.Text = "Cost";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(80, 109);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(61, 25);
            this.lblType.TabIndex = 57;
            this.lblType.Text = "Type";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle.Location = new System.Drawing.Point(58, 45);
            this.lblVehicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(130, 36);
            this.lblVehicle.TabIndex = 55;
            this.lblVehicle.Text = "Vehicle:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Location = new System.Drawing.Point(636, 525);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 38);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotalVehicalCashflow
            // 
            this.lblTotalVehicalCashflow.AutoSize = true;
            this.lblTotalVehicalCashflow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVehicalCashflow.Location = new System.Drawing.Point(62, 531);
            this.lblTotalVehicalCashflow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalVehicalCashflow.Name = "lblTotalVehicalCashflow";
            this.lblTotalVehicalCashflow.Size = new System.Drawing.Size(159, 22);
            this.lblTotalVehicalCashflow.TabIndex = 52;
            this.lblTotalVehicalCashflow.Text = "Vehical Cash-flow:";
            // 
            // cboActivitySelection
            // 
            this.cboActivitySelection.FormattingEnabled = true;
            this.cboActivitySelection.Items.AddRange(new object[] {
            "Relocation",
            "Service",
            "Hiring"});
            this.cboActivitySelection.Location = new System.Drawing.Point(206, 426);
            this.cboActivitySelection.Name = "cboActivitySelection";
            this.cboActivitySelection.Size = new System.Drawing.Size(175, 28);
            this.cboActivitySelection.TabIndex = 51;
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleID.Location = new System.Drawing.Point(202, 45);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(128, 36);
            this.lblVehicleID.TabIndex = 50;
            this.lblVehicleID.Text = "AKJ345";
            // 
            // btnDeleteActivity
            // 
            this.btnDeleteActivity.BackColor = System.Drawing.Color.LightGray;
            this.btnDeleteActivity.Location = new System.Drawing.Point(586, 422);
            this.btnDeleteActivity.Name = "btnDeleteActivity";
            this.btnDeleteActivity.Size = new System.Drawing.Size(134, 38);
            this.btnDeleteActivity.TabIndex = 49;
            this.btnDeleteActivity.Text = "Delete Activity";
            this.btnDeleteActivity.UseVisualStyleBackColor = false;
            this.btnDeleteActivity.Click += new System.EventHandler(this.btnDeleteActivity_Click);
            // 
            // btnEditActivity
            // 
            this.btnEditActivity.BackColor = System.Drawing.Color.LightGray;
            this.btnEditActivity.Location = new System.Drawing.Point(447, 422);
            this.btnEditActivity.Name = "btnEditActivity";
            this.btnEditActivity.Size = new System.Drawing.Size(134, 38);
            this.btnEditActivity.TabIndex = 48;
            this.btnEditActivity.Text = "Edit Activity";
            this.btnEditActivity.UseVisualStyleBackColor = false;
            this.btnEditActivity.Click += new System.EventHandler(this.btnEditActivity_Click);
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.BackColor = System.Drawing.Color.LightGray;
            this.btnAddActivity.Location = new System.Drawing.Point(66, 422);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(134, 38);
            this.btnAddActivity.TabIndex = 47;
            this.btnAddActivity.Text = "Add Activity";
            this.btnAddActivity.UseVisualStyleBackColor = false;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // txtTotalVehicleCashflow
            // 
            this.txtTotalVehicleCashflow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.txtTotalVehicleCashflow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVehicleCashflow.Location = new System.Drawing.Point(231, 529);
            this.txtTotalVehicleCashflow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalVehicleCashflow.Multiline = true;
            this.txtTotalVehicleCashflow.Name = "txtTotalVehicleCashflow";
            this.txtTotalVehicleCashflow.ReadOnly = true;
            this.txtTotalVehicleCashflow.Size = new System.Drawing.Size(150, 32);
            this.txtTotalVehicleCashflow.TabIndex = 63;
            this.txtTotalVehicleCashflow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstActivityLog
            // 
            this.lstActivityLog.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstActivityLog.FormattingEnabled = true;
            this.lstActivityLog.ItemHeight = 18;
            this.lstActivityLog.Location = new System.Drawing.Point(66, 154);
            this.lstActivityLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstActivityLog.Name = "lstActivityLog";
            this.lstActivityLog.Size = new System.Drawing.Size(652, 220);
            this.lstActivityLog.TabIndex = 64;
            this.lstActivityLog.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstActivityLog_MouseDoubleClick);
            // 
            // cboListSorter
            // 
            this.cboListSorter.FormattingEnabled = true;
            this.cboListSorter.Location = new System.Drawing.Point(538, 54);
            this.cboListSorter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboListSorter.Name = "cboListSorter";
            this.cboListSorter.Size = new System.Drawing.Size(180, 28);
            this.cboListSorter.TabIndex = 65;
            this.cboListSorter.SelectedIndexChanged += new System.EventHandler(this.cbListSorter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 66;
            this.label1.Text = "Sort by:";
            // 
            // FrmActivityLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(789, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboListSorter);
            this.Controls.Add(this.lstActivityLog);
            this.Controls.Add(this.txtTotalVehicleCashflow);
            this.Controls.Add(this.txtFindActivity);
            this.Controls.Add(this.btnFindActivity);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotalVehicalCashflow);
            this.Controls.Add(this.cboActivitySelection);
            this.Controls.Add(this.lblVehicleID);
            this.Controls.Add(this.btnDeleteActivity);
            this.Controls.Add(this.btnEditActivity);
            this.Controls.Add(this.btnAddActivity);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmActivityLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activity Log";
            this.Load += new System.EventHandler(this.FrmActivityLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFindActivity;
        private System.Windows.Forms.Button btnFindActivity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotalVehicalCashflow;
        private System.Windows.Forms.ComboBox cboActivitySelection;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.Button btnDeleteActivity;
        private System.Windows.Forms.Button btnEditActivity;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.TextBox txtTotalVehicleCashflow;
        private System.Windows.Forms.ListBox lstActivityLog;
        private System.Windows.Forms.ComboBox cboListSorter;
        private System.Windows.Forms.Label label1;
    }
}