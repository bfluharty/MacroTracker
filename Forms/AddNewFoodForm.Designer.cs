namespace MacroTracker.Forms
{
    partial class AddNewFoodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewFoodForm));
            this.title = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.proteinLabel = new System.Windows.Forms.Label();
            this.carbsLabel = new System.Windows.Forms.Label();
            this.caloriesInput = new System.Windows.Forms.NumericUpDown();
            this.fatInput = new System.Windows.Forms.NumericUpDown();
            this.carbsInput = new System.Windows.Forms.NumericUpDown();
            this.proteinInput = new System.Windows.Forms.NumericUpDown();
            this.nextButton = new System.Windows.Forms.Button();
            this.confirmationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proteinInput)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(9, 9);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(821, 97);
            this.title.TabIndex = 0;
            this.title.Text = "Add New Food";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(348, 494);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(145, 48);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add Food";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(129, 494);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(145, 48);
            this.menuButton.TabIndex = 3;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(123, 139);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(78, 31);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(277, 139);
            this.nameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(433, 38);
            this.nameInput.TabIndex = 5;
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesLabel.Location = new System.Drawing.Point(123, 197);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(100, 31);
            this.caloriesLabel.TabIndex = 6;
            this.caloriesLabel.Text = "Calories:";
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatLabel.Location = new System.Drawing.Point(123, 255);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(52, 31);
            this.fatLabel.TabIndex = 8;
            this.fatLabel.Text = "Fat:";
            // 
            // proteinLabel
            // 
            this.proteinLabel.AutoSize = true;
            this.proteinLabel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinLabel.Location = new System.Drawing.Point(123, 372);
            this.proteinLabel.Name = "proteinLabel";
            this.proteinLabel.Size = new System.Drawing.Size(89, 31);
            this.proteinLabel.TabIndex = 12;
            this.proteinLabel.Text = "Protein:";
            // 
            // carbsLabel
            // 
            this.carbsLabel.AutoSize = true;
            this.carbsLabel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbsLabel.Location = new System.Drawing.Point(123, 313);
            this.carbsLabel.Name = "carbsLabel";
            this.carbsLabel.Size = new System.Drawing.Size(78, 31);
            this.carbsLabel.TabIndex = 10;
            this.carbsLabel.Text = "Carbs:";
            // 
            // caloriesInput
            // 
            this.caloriesInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.caloriesInput.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesInput.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.caloriesInput.Location = new System.Drawing.Point(277, 196);
            this.caloriesInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.caloriesInput.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.caloriesInput.Name = "caloriesInput";
            this.caloriesInput.Size = new System.Drawing.Size(141, 38);
            this.caloriesInput.TabIndex = 14;
            // 
            // fatInput
            // 
            this.fatInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fatInput.DecimalPlaces = 1;
            this.fatInput.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatInput.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.fatInput.Location = new System.Drawing.Point(277, 254);
            this.fatInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fatInput.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.fatInput.Name = "fatInput";
            this.fatInput.Size = new System.Drawing.Size(141, 38);
            this.fatInput.TabIndex = 15;
            // 
            // carbsInput
            // 
            this.carbsInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.carbsInput.DecimalPlaces = 1;
            this.carbsInput.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbsInput.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.carbsInput.Location = new System.Drawing.Point(277, 313);
            this.carbsInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carbsInput.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.carbsInput.Name = "carbsInput";
            this.carbsInput.Size = new System.Drawing.Size(141, 38);
            this.carbsInput.TabIndex = 16;
            // 
            // proteinInput
            // 
            this.proteinInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.proteinInput.DecimalPlaces = 1;
            this.proteinInput.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinInput.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.proteinInput.Location = new System.Drawing.Point(277, 370);
            this.proteinInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proteinInput.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.proteinInput.Name = "proteinInput";
            this.proteinInput.Size = new System.Drawing.Size(141, 38);
            this.proteinInput.TabIndex = 17;
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(567, 494);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(145, 48);
            this.nextButton.TabIndex = 18;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmationLabel.Location = new System.Drawing.Point(129, 420);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(583, 70);
            this.confirmationLabel.TabIndex = 19;
            this.confirmationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddNewFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 554);
            this.Controls.Add(this.confirmationLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.proteinInput);
            this.Controls.Add(this.carbsInput);
            this.Controls.Add(this.fatInput);
            this.Controls.Add(this.caloriesInput);
            this.Controls.Add(this.proteinLabel);
            this.Controls.Add(this.carbsLabel);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddNewFoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MacroTracker - Add New Food";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddNewFoodForm_FormClosed);
            this.Shown += new System.EventHandler(this.AddNewFoodForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.caloriesInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proteinInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label proteinLabel;
        private System.Windows.Forms.Label carbsLabel;
        private System.Windows.Forms.NumericUpDown caloriesInput;
        private System.Windows.Forms.NumericUpDown fatInput;
        private System.Windows.Forms.NumericUpDown carbsInput;
        private System.Windows.Forms.NumericUpDown proteinInput;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label confirmationLabel;
    }
}