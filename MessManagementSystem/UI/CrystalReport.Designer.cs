namespace MessManagementSystem.UI
{
    partial class CrystalReport
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
            this.mealCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // mealCrystalReportViewer
            // 
            this.mealCrystalReportViewer.ActiveViewIndex = -1;
            this.mealCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mealCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.mealCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mealCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.mealCrystalReportViewer.Name = "mealCrystalReportViewer";
            this.mealCrystalReportViewer.Size = new System.Drawing.Size(824, 423);
            this.mealCrystalReportViewer.TabIndex = 0;
            // 
            // CrystalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 423);
            this.Controls.Add(this.mealCrystalReportViewer);
            this.Name = "CrystalReport";
            this.Text = "CrystalReport";
            this.Load += new System.EventHandler(this.CrystalReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer mealCrystalReportViewer;
    }
}