namespace CarRentalBusiness_FD_
{
    partial class FrmRelocationActivity
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
            this.lblKilometres = new System.Windows.Forms.Label();
            this.numKilometres = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numInputAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKilometres)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActivity
            // 
            this.lblActivity.Location = new System.Drawing.Point(182, 35);
            this.lblActivity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivity.Size = new System.Drawing.Size(157, 36);
            this.lblActivity.Text = "Relocation";
            // 
            // lblName
            // 
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Size = new System.Drawing.Size(100, 26);
            this.lblName.Text = "Location:";
            // 
            // txtName
            // 
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // numInputAmount
            // 
            this.numInputAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblKilometres
            // 
            this.lblKilometres.AutoSize = true;
            this.lblKilometres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilometres.Location = new System.Drawing.Point(42, 289);
            this.lblKilometres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKilometres.Name = "lblKilometres";
            this.lblKilometres.Size = new System.Drawing.Size(122, 26);
            this.lblKilometres.TabIndex = 31;
            this.lblKilometres.Text = "Kilometres:";
            // 
            // numKilometres
            // 
            this.numKilometres.Location = new System.Drawing.Point(189, 286);
            this.numKilometres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numKilometres.Name = "numKilometres";
            this.numKilometres.Size = new System.Drawing.Size(270, 26);
            this.numKilometres.TabIndex = 32;
            // 
            // FrmRelocationActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(519, 440);
            this.Controls.Add(this.numKilometres);
            this.Controls.Add(this.lblKilometres);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FrmRelocationActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relocation";
            this.Load += new System.EventHandler(this.FrmRelocationActivity_Load);
            this.Controls.SetChildIndex(this.numInputAmount, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.lblCost, 0);
            this.Controls.SetChildIndex(this.lblActivity, 0);
            this.Controls.SetChildIndex(this.dtpDate, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblDate, 0);
            this.Controls.SetChildIndex(this.lblKilometres, 0);
            this.Controls.SetChildIndex(this.numKilometres, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numInputAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKilometres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKilometres;
        protected System.Windows.Forms.NumericUpDown numKilometres;
    }
}
