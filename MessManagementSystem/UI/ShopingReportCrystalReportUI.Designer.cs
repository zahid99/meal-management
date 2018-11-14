namespace MessManagementSystem.UI
{
    partial class ShopingReportCrystalReportUI
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
            this.shopingCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // shopingCrystalReportViewer
            // 
            this.shopingCrystalReportViewer.ActiveViewIndex = -1;
            this.shopingCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shopingCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.shopingCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopingCrystalReportViewer.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopingCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.shopingCrystalReportViewer.Name = "shopingCrystalReportViewer";
            this.shopingCrystalReportViewer.Size = new System.Drawing.Size(786, 444);
            this.shopingCrystalReportViewer.TabIndex = 0;
            // 
            // ShopingReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 444);
            this.Controls.Add(this.shopingCrystalReportViewer);
            this.Name = "ShopingReportUI";
            this.Text = "ShopingReportUI";
            this.Load += new System.EventHandler(this.ShopingReportUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer shopingCrystalReportViewer;
    }
}