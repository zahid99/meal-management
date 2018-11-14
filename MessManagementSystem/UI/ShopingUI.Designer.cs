namespace MessManagementSystem.UI
{
    partial class ShopingUI
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
            this.saveButton = new System.Windows.Forms.Button();
            this.shopingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shopingListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hiddelIdLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.monthLabel = new System.Windows.Forms.Label();
            this.reportButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(301, 159);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 32);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // shopingDateTimePicker
            // 
            this.shopingDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shopingDateTimePicker.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.shopingDateTimePicker.Location = new System.Drawing.Point(170, 75);
            this.shopingDateTimePicker.Name = "shopingDateTimePicker";
            this.shopingDateTimePicker.Size = new System.Drawing.Size(246, 26);
            this.shopingDateTimePicker.TabIndex = 1;
            // 
            // nameComboBox
            // 
            this.nameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameComboBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(170, 40);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(246, 26);
            this.nameComboBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Member Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cost";
            // 
            // costTextBox
            // 
            this.costTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.costTextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTextBox.Location = new System.Drawing.Point(170, 112);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(246, 26);
            this.costTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, -49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "S h o p i n g   C o s t";
            // 
            // shopingListView
            // 
            this.shopingListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shopingListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.shopingListView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopingListView.FullRowSelect = true;
            this.shopingListView.GridLines = true;
            this.shopingListView.Location = new System.Drawing.Point(436, 40);
            this.shopingListView.Name = "shopingListView";
            this.shopingListView.Size = new System.Drawing.Size(501, 270);
            this.shopingListView.TabIndex = 13;
            this.shopingListView.UseCompatibleStateImageBehavior = false;
            this.shopingListView.View = System.Windows.Forms.View.Details;
            this.shopingListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.shopingListView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Shoping Date";
            this.columnHeader1.Width = 164;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 143;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cost";
            this.columnHeader3.Width = 64;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SubCost";
            this.columnHeader4.Width = 73;
            // 
            // hiddelIdLabel
            // 
            this.hiddelIdLabel.AutoSize = true;
            this.hiddelIdLabel.Location = new System.Drawing.Point(12, 154);
            this.hiddelIdLabel.Name = "hiddelIdLabel";
            this.hiddelIdLabel.Size = new System.Drawing.Size(35, 13);
            this.hiddelIdLabel.TabIndex = 14;
            this.hiddelIdLabel.Text = "label5";
            this.hiddelIdLabel.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(170, 159);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(115, 32);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // monthLabel
            // 
            this.monthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(576, 4);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(105, 25);
            this.monthLabel.TabIndex = 12;
            this.monthLabel.Text = "M o n t h";
            // 
            // reportButton
            // 
            this.reportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.Location = new System.Drawing.Point(822, 351);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(115, 32);
            this.reportButton.TabIndex = 11;
            this.reportButton.Text = "Print";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeButton.Enabled = false;
            this.removeButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(224, 207);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(160, 32);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // ShopingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 494);
            this.Controls.Add(this.hiddelIdLabel);
            this.Controls.Add(this.shopingListView);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.shopingDateTimePicker);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costTextBox);
            this.Name = "ShopingUI";
            this.Text = "ShopingUI";
            this.Load += new System.EventHandler(this.ShopingUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker shopingDateTimePicker;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView shopingListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label hiddelIdLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button removeButton;
    }
}