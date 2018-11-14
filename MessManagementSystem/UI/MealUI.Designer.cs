namespace MessManagementSystem.UI
{
    partial class MealUI
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
            this.totalMealTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mealDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mealListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.hiddenIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalMealTextBox
            // 
            this.totalMealTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalMealTextBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMealTextBox.Location = new System.Drawing.Point(189, 161);
            this.totalMealTextBox.Name = "totalMealTextBox";
            this.totalMealTextBox.Size = new System.Drawing.Size(225, 26);
            this.totalMealTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Meal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameComboBox
            // 
            this.nameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameComboBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(189, 124);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(225, 26);
            this.nameComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member Name";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // mealDateTimePicker
            // 
            this.mealDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mealDateTimePicker.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mealDateTimePicker.Location = new System.Drawing.Point(189, 89);
            this.mealDateTimePicker.Name = "mealDateTimePicker";
            this.mealDateTimePicker.Size = new System.Drawing.Size(225, 26);
            this.mealDateTimePicker.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(298, 202);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(116, 32);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "D a i l y   M e a l";
            // 
            // mealListView
            // 
            this.mealListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mealListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.mealListView.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealListView.FullRowSelect = true;
            this.mealListView.GridLines = true;
            this.mealListView.Location = new System.Drawing.Point(450, 89);
            this.mealListView.Name = "mealListView";
            this.mealListView.Size = new System.Drawing.Size(392, 225);
            this.mealListView.TabIndex = 6;
            this.mealListView.UseCompatibleStateImageBehavior = false;
            this.mealListView.View = System.Windows.Forms.View.Details;
            this.mealListView.DoubleClick += new System.EventHandler(this.mealListView_DoubleClick);
            this.mealListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mealListView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SNO";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Member Name";
            this.columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 112;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Meal";
            this.columnHeader4.Width = 82;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(447, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "view last 3 date meal here";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // monthLabel
            // 
            this.monthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(658, 51);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(61, 18);
            this.monthLabel.TabIndex = 1;
            this.monthLabel.Text = "month";
            this.monthLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(176, 202);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(116, 32);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeButton.Enabled = false;
            this.removeButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(245, 252);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(116, 32);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // hiddenIdLabel
            // 
            this.hiddenIdLabel.AutoSize = true;
            this.hiddenIdLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenIdLabel.Location = new System.Drawing.Point(771, 31);
            this.hiddenIdLabel.Name = "hiddenIdLabel";
            this.hiddenIdLabel.Size = new System.Drawing.Size(61, 18);
            this.hiddenIdLabel.TabIndex = 1;
            this.hiddenIdLabel.Text = "month";
            this.hiddenIdLabel.Visible = false;
            this.hiddenIdLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MealUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 334);
            this.Controls.Add(this.mealListView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.mealDateTimePicker);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hiddenIdLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalMealTextBox);
            this.Name = "MealUI";
            this.Text = "MealUI";
            this.Load += new System.EventHandler(this.MealUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalMealTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker mealDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView mealListView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label hiddenIdLabel;
    }
}