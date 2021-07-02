namespace MacroTracker.Forms
{
    partial class EnterMacroGoalsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterMacroGoalsForm));
            this.proteinInput = new System.Windows.Forms.NumericUpDown();
            this.carbsInput = new System.Windows.Forms.NumericUpDown();
            this.fatInput = new System.Windows.Forms.NumericUpDown();
            this.caloriesInput = new System.Windows.Forms.NumericUpDown();
            this.proteinLabel = new System.Windows.Forms.Label();
            this.carbsLabel = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proteinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesInput)).BeginInit();
            this.SuspendLayout();
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
            this.proteinInput.Location = new System.Drawing.Point(405, 281);
            this.proteinInput.Margin = new System.Windows.Forms.Padding(2);
            this.proteinInput.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.proteinInput.Name = "proteinInput";
            this.proteinInput.Size = new System.Drawing.Size(106, 38);
            this.proteinInput.TabIndex = 28;
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
            this.carbsInput.Location = new System.Drawing.Point(405, 235);
            this.carbsInput.Margin = new System.Windows.Forms.Padding(2);
            this.carbsInput.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.carbsInput.Name = "carbsInput";
            this.carbsInput.Size = new System.Drawing.Size(106, 38);
            this.carbsInput.TabIndex = 27;
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
            this.fatInput.Location = new System.Drawing.Point(405, 189);
            this.fatInput.Margin = new System.Windows.Forms.Padding(2);
            this.fatInput.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.fatInput.Name = "fatInput";
            this.fatInput.Size = new System.Drawing.Size(106, 38);
            this.fatInput.TabIndex = 26;
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
            this.caloriesInput.Location = new System.Drawing.Point(405, 143);
            this.caloriesInput.Margin = new System.Windows.Forms.Padding(2);
            this.caloriesInput.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.caloriesInput.Name = "caloriesInput";
            this.caloriesInput.Size = new System.Drawing.Size(106, 38);
            this.caloriesInput.TabIndex = 25;
            // 
            // proteinLabel
            // 
            this.proteinLabel.AutoSize = true;
            this.proteinLabel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinLabel.Location = new System.Drawing.Point(289, 283);
            this.proteinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.proteinLabel.Name = "proteinLabel";
            this.proteinLabel.Size = new System.Drawing.Size(89, 31);
            this.proteinLabel.TabIndex = 24;
            this.proteinLabel.Text = "Protein:";
            // 
            // carbsLabel
            // 
            this.carbsLabel.AutoSize = true;
            this.carbsLabel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbsLabel.Location = new System.Drawing.Point(289, 237);
            this.carbsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carbsLabel.Name = "carbsLabel";
            this.carbsLabel.Size = new System.Drawing.Size(78, 31);
            this.carbsLabel.TabIndex = 23;
            this.carbsLabel.Text = "Carbs:";
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatLabel.Location = new System.Drawing.Point(289, 191);
            this.fatLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(52, 31);
            this.fatLabel.TabIndex = 22;
            this.fatLabel.Text = "Fat:";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesLabel.Location = new System.Drawing.Point(289, 145);
            this.caloriesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(100, 31);
            this.caloriesLabel.TabIndex = 21;
            this.caloriesLabel.Text = "Calories:";
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(9, 9);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(782, 79);
            this.title.TabIndex = 18;
            this.title.Text = "Set Your Daily Macro Goals";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(408, 399);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(109, 39);
            this.submitButton.TabIndex = 29;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Enabled = false;
            this.menuButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(283, 399);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(109, 39);
            this.menuButton.TabIndex = 30;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // EnterMacroGoalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.proteinInput);
            this.Controls.Add(this.carbsInput);
            this.Controls.Add(this.fatInput);
            this.Controls.Add(this.caloriesInput);
            this.Controls.Add(this.proteinLabel);
            this.Controls.Add(this.carbsLabel);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnterMacroGoalsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MacroTracker - Macro Goals";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterMacroGoalsForm_FormClosed);
            this.Shown += new System.EventHandler(this.EnterMacroGoalsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.proteinInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown proteinInput;
        private System.Windows.Forms.NumericUpDown carbsInput;
        private System.Windows.Forms.NumericUpDown fatInput;
        private System.Windows.Forms.NumericUpDown caloriesInput;
        private System.Windows.Forms.Label proteinLabel;
        private System.Windows.Forms.Label carbsLabel;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button menuButton;
    }
}