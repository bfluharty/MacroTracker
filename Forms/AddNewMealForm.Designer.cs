namespace MacroTracker.Forms
{
    partial class AddNewMealForm
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
            this.components = new System.ComponentModel.Container();
            this.confirmationLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.mealTypeBox = new System.Windows.Forms.ComboBox();
            this.mealTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateLabel = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.mealLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mealTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmationLabel.Location = new System.Drawing.Point(67, 337);
            this.confirmationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(672, 63);
            this.confirmationLabel.TabIndex = 34;
            this.confirmationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(419, 403);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(109, 39);
            this.nextButton.TabIndex = 33;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(260, 403);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(109, 39);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(92, 9);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(616, 79);
            this.title.TabIndex = 20;
            this.title.Text = "Select Meal";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mealTypeBox
            // 
            this.mealTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mealTypeBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealTypeBox.FormattingEnabled = true;
            this.mealTypeBox.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Snack"});
            this.mealTypeBox.Location = new System.Drawing.Point(211, 205);
            this.mealTypeBox.MaxDropDownItems = 4;
            this.mealTypeBox.Name = "mealTypeBox";
            this.mealTypeBox.Size = new System.Drawing.Size(158, 40);
            this.mealTypeBox.TabIndex = 35;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(413, 208);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(81, 32);
            this.dateLabel.TabIndex = 36;
            this.dateLabel.Text = "Date:";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.CustomFormat = "M/dd/yyyy";
            this.datePicker.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(499, 206);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowUpDown = true;
            this.datePicker.Size = new System.Drawing.Size(180, 39);
            this.datePicker.TabIndex = 37;
            this.datePicker.Value = new System.DateTime(2021, 6, 10, 0, 29, 20, 0);
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealLabel.Location = new System.Drawing.Point(121, 208);
            this.mealLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(82, 32);
            this.mealLabel.TabIndex = 38;
            this.mealLabel.Text = "Meal:";
            this.mealLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddNewMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mealLabel);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.mealTypeBox);
            this.Controls.Add(this.confirmationLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.title);
            this.Name = "AddNewMealForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MacroTracker - Record Meal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecordMealForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.mealTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confirmationLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox mealTypeBox;
        private System.Windows.Forms.BindingSource mealTypesBindingSource;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label mealLabel;
    }
}