namespace MessManagementSystem.UI
{
    partial class DepositUI
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
            this.label4 = new System.Windows.Forms.Label();
            this.saveDepositAmountButton = new System.Windows.Forms.Button();
            this.depositDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.depositListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HiddenIdLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.monthLabel = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "D e p o s i t   U i";
            // 
            // saveDepositAmountButton
            // 
            this.saveDepositAmountButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveDepositAmountButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDepositAmountButton.Location = new System.Drawing.Point(396, 267);
            this.saveDepositAmountButton.Name = "saveDepositAmountButton";
            this.saveDepositAmountButton.Size = new System.Drawing.Size(116, 32);
            this.saveDepositAmountButton.TabIndex = 9;
            this.saveDepositAmountButton.Text = "Save";
            this.saveDepositAmountButton.UseVisualStyleBackColor = true;
            this.saveDepositAmountButton.Click += new System.EventHandler(this.saveDepositAmountButton_Click);
            // 
            // depositDateTimePicker
            // 
            this.depositDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.depositDateTimePicker.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.depositDateTimePicker.Location = new System.Drawing.Point(214, 175);
            this.depositDateTimePicker.Name = "depositDateTimePicker";
            this.depositDateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.depositDateTimePicker.TabIndex = 1;
            // 
            // nameComboBox
            // 
            this.nameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameComboBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(214, 143);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(298, 26);
            this.nameComboBox.TabIndex = 0;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountTextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextBox.Location = new System.Drawing.Point(214, 207);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(298, 26);
            this.amountTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Member Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Amount";
            // 
            // depositListView
            // 
            this.depositListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.depositListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.depositListView.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositListView.FullRowSelect = true;
            this.depositListView.GridLines = true;
            this.depositListView.Location = new System.Drawing.Point(543, 143);
            this.depositListView.Name = "depositListView";
            this.depositListView.Size = new System.Drawing.Size(415, 355);
            this.depositListView.TabIndex = 14;
            this.depositListView.UseCompatibleStateImageBehavior = false;
            this.depositListView.View = System.Windows.Forms.View.Details;
            this.depositListView.DoubleClick += new System.EventHandler(this.depositListView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Member Name";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 123;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amont";
            // 
            // HiddenIdLabel
            // 
            this.HiddenIdLabel.AutoSize = true;
            this.HiddenIdLabel.Location = new System.Drawing.Point(559, 39);
            this.HiddenIdLabel.Name = "HiddenIdLabel";
            this.HiddenIdLabel.Size = new System.Drawing.Size(35, 13);
            this.HiddenIdLabel.TabIndex = 15;
            this.HiddenIdLabel.Text = "label5";
            this.HiddenIdLabel.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(257, 267);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(116, 32);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeButton.Enabled = false;
            this.removeButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(135, 267);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(116, 32);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(35, 90);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(115, 32);
            this.homeButton.TabIndex = 16;
            this.homeButton.Text = "H O M E";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // monthLabel
            // 
            this.monthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(614, 104);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(79, 25);
            this.monthLabel.TabIndex = 12;
            this.monthLabel.Text = "month";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sub-Total";
            this.columnHeader4.Width = 94;
            // 
            // reportButton
            // 
            this.reportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.Location = new System.Drawing.Point(843, 504);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(115, 32);
            this.reportButton.TabIndex = 17;
            this.reportButton.Text = "Print";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // DepositUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 548);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.HiddenIdLabel);
            this.Controls.Add(this.depositListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.saveDepositAmountButton);
            this.Controls.Add(this.depositDateTimePicker);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.amountTextBox);
            this.Name = "DepositUI";
            this.Text = "DepositUI";
            this.Load += new System.EventHandler(this.DepositUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveDepositAmountButton;
        private System.Windows.Forms.DateTimePicker depositDateTimePicker;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView depositListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label HiddenIdLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button reportButton;
    }
}