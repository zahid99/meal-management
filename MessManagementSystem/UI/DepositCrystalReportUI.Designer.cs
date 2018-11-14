namespace MessManagementSystem.UI
{
    partial class DepositCrystalReportUI
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
            this.depositCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // depositCrystalReportViewer
            // 
            this.depositCrystalReportViewer.ActiveViewIndex = -1;
            this.depositCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.depositCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.depositCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depositCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.depositCrystalReportViewer.Name = "depositCrystalReportViewer";
            this.depositCrystalReportViewer.Size = new System.Drawing.Size(765, 449);
            this.depositCrystalReportViewer.TabIndex = 0;
            this.depositCrystalReportViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // DepositCrystalReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 449);
            this.Controls.Add(this.depositCrystalReportViewer);
            this.Name = "DepositCrystalReportUI";
            this.Text = "DepositCrystalReportUI";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer depositCrystalReportViewer;
    }
}