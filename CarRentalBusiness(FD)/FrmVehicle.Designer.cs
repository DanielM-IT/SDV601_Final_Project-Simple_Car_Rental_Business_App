namespace CarRentalBusiness_FD_
{
    partial class FrmVehicle
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
            this.numDailyHire = new System.Windows.Forms.NumericUpDown();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.btnActivityLog = new System.Windows.Forms.Button();
            this.lblRegistrationNo = new System.Windows.Forms.Label();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.lblInputDirections = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblDailyHire = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDailyHire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.SuspendLayout();
            // 
            // numDailyHire
            // 
            this.numDailyHire.DecimalPlaces = 2;
            this.numDailyHire.Location = new System.Drawing.Point(254, 335);
            this.numDailyHire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numDailyHire.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numDailyHire.Name = "numDailyHire";
            this.numDailyHire.Size = new System.Drawing.Size(230, 26);
            this.numDailyHire.TabIndex = 46;
            this.numDailyHire.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDailyHire.ValueChanged += new System.EventHandler(this.numDailyHire_ValueChanged);
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(254, 275);
            this.numYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numYear.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(230, 26);
            this.numYear.TabIndex = 45;
            // 
            // btnActivityLog
            // 
            this.btnActivityLog.BackColor = System.Drawing.Color.LightGray;
            this.btnActivityLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActivityLog.Location = new System.Drawing.Point(273, 402);
            this.btnActivityLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActivityLog.Name = "btnActivityLog";
            this.btnActivityLog.Size = new System.Drawing.Size(177, 35);
            this.btnActivityLog.TabIndex = 44;
            this.btnActivityLog.Text = "Activity Log";
            this.btnActivityLog.UseVisualStyleBackColor = false;
            this.btnActivityLog.Click += new System.EventHandler(this.btnActivityLog_Click);
            // 
            // lblRegistrationNo
            // 
            this.lblRegistrationNo.AutoSize = true;
            this.lblRegistrationNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationNo.Location = new System.Drawing.Point(38, 100);
            this.lblRegistrationNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrationNo.Name = "lblRegistrationNo";
            this.lblRegistrationNo.Size = new System.Drawing.Size(150, 25);
            this.lblRegistrationNo.TabIndex = 43;
            this.lblRegistrationNo.Text = "Registration No:";
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.BackColor = System.Drawing.Color.White;
            this.txtRegistrationNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegistrationNo.Location = new System.Drawing.Point(254, 95);
            this.txtRegistrationNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegistrationNo.MaxLength = 6;
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(228, 26);
            this.txtRegistrationNo.TabIndex = 42;
            this.txtRegistrationNo.TextChanged += new System.EventHandler(this.txtRegistrationNo_TextChanged);
            // 
            // lblInputDirections
            // 
            this.lblInputDirections.AutoSize = true;
            this.lblInputDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputDirections.Location = new System.Drawing.Point(50, 52);
            this.lblInputDirections.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputDirections.Name = "lblInputDirections";
            this.lblInputDirections.Size = new System.Drawing.Size(419, 22);
            this.lblInputDirections.TabIndex = 41;
            this.lblInputDirections.Text = "Please enter vehicle details into the provided fields.";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(375, 457);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightGray;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Location = new System.Drawing.Point(231, 457);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 35);
            this.btnOK.TabIndex = 39;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(254, 215);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(228, 26);
            this.txtModel.TabIndex = 38;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(254, 154);
            this.txtMake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(228, 26);
            this.txtMake.TabIndex = 37;
            // 
            // lblDailyHire
            // 
            this.lblDailyHire.AutoSize = true;
            this.lblDailyHire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyHire.Location = new System.Drawing.Point(38, 335);
            this.lblDailyHire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDailyHire.Name = "lblDailyHire";
            this.lblDailyHire.Size = new System.Drawing.Size(129, 25);
            this.lblDailyHire.TabIndex = 36;
            this.lblDailyHire.Text = "Daily Hire:   ";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(40, 274);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(64, 25);
            this.lblYear.TabIndex = 35;
            this.lblYear.Text = "Year:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(38, 215);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(77, 25);
            this.lblModel.TabIndex = 34;
            this.lblModel.Text = "Model:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(40, 154);
            this.lblMake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(71, 25);
            this.lblMake.TabIndex = 33;
            this.lblMake.Text = "Make:";
            // 
            // FrmVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(531, 529);
            this.Controls.Add(this.numDailyHire);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.btnActivityLog);
            this.Controls.Add(this.lblRegistrationNo);
            this.Controls.Add(this.txtRegistrationNo);
            this.Controls.Add(this.lblInputDirections);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblDailyHire);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.FrmVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDailyHire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numDailyHire;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Button btnActivityLog;
        private System.Windows.Forms.Label lblRegistrationNo;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.Label lblInputDirections;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtModel;
        protected System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblDailyHire;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
    }
}