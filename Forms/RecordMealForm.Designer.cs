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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordMealForm));
            this.confirmationLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.servingsInput = new System.Windows.Forms.NumericUpDown();
            this.servingsLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.foodLabel = new System.Windows.Forms.Label();
            this.mealTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuButton = new System.Windows.Forms.Button();
            this.foodBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.servingsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmationLabel.Location = new System.Drawing.Point(64, 401);
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
            this.nextButton.Location = new System.Drawing.Point(610, 489);
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
            this.servingsInput.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servingsInput.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.servingsInput.Location = new System.Drawing.Point(598, 183);
            this.servingsInput.Margin = new System.Windows.Forms.Padding(2);
            this.servingsInput.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.servingsInput.Name = "servingsInput";
            this.servingsInput.Size = new System.Drawing.Size(111, 39);
            this.servingsInput.TabIndex = 32;
            this.servingsInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.servingsInput_KeyDown);
            // 
            // servingsLabel
            // 
            this.servingsLabel.AutoSize = true;
            this.servingsLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servingsLabel.Location = new System.Drawing.Point(592, 141);
            this.servingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.servingsLabel.Name = "servingsLabel";
            this.servingsLabel.Size = new System.Drawing.Size(120, 32);
            this.servingsLabel.TabIndex = 28;
            this.servingsLabel.Text = "Servings";
            this.servingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(258, 489);
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
            this.addButton.Location = new System.Drawing.Point(434, 489);
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
            this.title.Location = new System.Drawing.Point(93, 9);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(616, 79);
            this.title.TabIndex = 20;
            this.title.Text = "Select Foods";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel.Location = new System.Drawing.Point(252, 141);
            this.foodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(77, 32);
            this.foodLabel.TabIndex = 40;
            this.foodLabel.Text = "Food";
            this.foodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(82, 489);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(109, 39);
            this.menuButton.TabIndex = 42;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // foodBox
            // 
            this.foodBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.foodBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.foodBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodBox.Location = new System.Drawing.Point(47, 184);
            this.foodBox.Name = "foodBox";
            this.foodBox.Size = new System.Drawing.Size(458, 39);
            this.foodBox.TabIndex = 43;
            this.foodBox.TextChanged += new System.EventHandler(this.foodBox_TextChanged);
            this.foodBox.DoubleClick += new System.EventHandler(this.foodBox_DoubleClick);
            this.foodBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.foodBox_KeyDown);
            // 
            // RecordMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.confirmationLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.servingsInput);
            this.Controls.Add(this.servingsLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.title);
            this.Controls.Add(this.foodBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecordMealForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MacroTracker - Record Meal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecordMealForm_FormClosed);
            this.Shown += new System.EventHandler(this.RecordMealForm_Shown);
            this.Click += new System.EventHandler(this.RecordMealForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.servingsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confirmationLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.NumericUpDown servingsInput;
        private System.Windows.Forms.Label servingsLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.BindingSource mealTypesBindingSource;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.TextBox foodBox;
    }
}