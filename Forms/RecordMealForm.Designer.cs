namespace MacroTracker.Forms
{
    partial class RecordMealForm
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
            this.servingsInput = new System.Windows.Forms.NumericUpDown();
            this.proteinLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.foodComboBox = new System.Windows.Forms.ComboBox();
            this.foodLabel = new System.Windows.Forms.Label();
            this.mealLabel = new System.Windows.Forms.Label();
            this.mealTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.servingsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmationLabel.Location = new System.Drawing.Point(67, 321);
            this.confirmationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(672, 63);
            this.confirmationLabel.TabIndex = 34;
            this.confirmationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(610, 403);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(109, 39);
            this.nextButton.TabIndex = 33;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // servingsInput
            // 
            this.servingsInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.servingsInput.DecimalPlaces = 1;
            this.servingsInput.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servingsInput.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.servingsInput.Location = new System.Drawing.Point(285, 269);
            this.servingsInput.Margin = new System.Windows.Forms.Padding(2);
            this.servingsInput.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.servingsInput.Name = "servingsInput";
            this.servingsInput.Size = new System.Drawing.Size(83, 38);
            this.servingsInput.TabIndex = 32;
            // 
            // proteinLabel
            // 
            this.proteinLabel.AutoSize = true;
            this.proteinLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinLabel.Location = new System.Drawing.Point(153, 270);
            this.proteinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.proteinLabel.Name = "proteinLabel";
            this.proteinLabel.Size = new System.Drawing.Size(128, 32);
            this.proteinLabel.TabIndex = 28;
            this.proteinLabel.Text = "Servings:";
            this.proteinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(258, 403);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(109, 39);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(434, 403);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(109, 39);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Add Food";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            this.title.Text = "Select Foods";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodComboBox
            // 
            this.foodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foodComboBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodComboBox.FormattingEnabled = true;
            this.foodComboBox.Location = new System.Drawing.Point(285, 192);
            this.foodComboBox.MaxDropDownItems = 5;
            this.foodComboBox.Name = "foodComboBox";
            this.foodComboBox.Size = new System.Drawing.Size(366, 40);
            this.foodComboBox.TabIndex = 39;
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel.Location = new System.Drawing.Point(153, 195);
            this.foodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(85, 32);
            this.foodLabel.TabIndex = 40;
            this.foodLabel.Text = "Food:";
            this.foodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mealLabel
            // 
            this.mealLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealLabel.Location = new System.Drawing.Point(153, 120);
            this.mealLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(498, 32);
            this.mealLabel.TabIndex = 41;
            this.mealLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(82, 403);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(109, 39);
            this.menuButton.TabIndex = 42;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // RecordMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.mealLabel);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.foodComboBox);
            this.Controls.Add(this.confirmationLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.servingsInput);
            this.Controls.Add(this.proteinLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.title);
            this.Name = "RecordMealForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MacroTracker - Record Meal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecordMealForm_FormClosed);
            this.Shown += new System.EventHandler(this.RecordMealForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.servingsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confirmationLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.NumericUpDown servingsInput;
        private System.Windows.Forms.Label proteinLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.BindingSource mealTypesBindingSource;
        private System.Windows.Forms.ComboBox foodComboBox;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.Button menuButton;
    }
}