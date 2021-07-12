namespace MacroTracker.Forms
{
    partial class EditNewMealForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditNewMealForm));
            this.confirmationLabel = new System.Windows.Forms.Label();
            this.servingsInput = new System.Windows.Forms.NumericUpDown();
            this.servingsLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.foodLabel = new System.Windows.Forms.Label();
            this.mealTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
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
            this.servingsInput.Location = new System.Drawing.Point(598, 183);
            this.servingsInput.Margin = new System.Windows.Forms.Padding(2);
            this.servingsInput.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.servingsInput.Name = "servingsInput";
            this.servingsInput.Size = new System.Drawing.Size(83, 38);
            this.servingsInput.TabIndex = 32;
            this.servingsInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.servingsInput_KeyDown);
            // 
            // servingsLabel
            // 
            this.servingsLabel.AutoSize = true;
            this.servingsLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servingsLabel.Location = new System.Drawing.Point(578, 141);
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
            this.backButton.Location = new System.Drawing.Point(230, 489);
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
            this.title.Location = new System.Drawing.Point(93, 9);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(616, 79);
            this.title.TabIndex = 20;
            this.title.Text = "Edit Meal";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel.Location = new System.Drawing.Point(191, 141);
            this.foodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(77, 32);
            this.foodLabel.TabIndex = 40;
            this.foodLabel.Text = "Food";
            this.foodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodBox
            // 
            this.foodBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.foodBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.foodBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodBox.Location = new System.Drawing.Point(48, 184);
            this.foodBox.Name = "foodBox";
            this.foodBox.Size = new System.Drawing.Size(366, 39);
            this.foodBox.TabIndex = 43;
            this.foodBox.TextChanged += new System.EventHandler(this.foodBox_TextChanged);
            this.foodBox.DoubleClick += new System.EventHandler(this.foodBox_DoubleClick);
            this.foodBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.foodBox_KeyDown);
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(461, 489);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(109, 39);
            this.confirmButton.TabIndex = 44;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // EditNewMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.confirmationLabel);
            this.Controls.Add(this.servingsInput);
            this.Controls.Add(this.servingsLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.title);
            this.Controls.Add(this.foodBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditNewMealForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MacroTracker - Edit Meal";
            this.Shown += new System.EventHandler(this.EditNewMealForm_Shown);
            this.Click += new System.EventHandler(this.EditNewMealForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.servingsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confirmationLabel;
        private System.Windows.Forms.NumericUpDown servingsInput;
        private System.Windows.Forms.Label servingsLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.BindingSource mealTypesBindingSource;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.TextBox foodBox;
        private System.Windows.Forms.Button confirmButton;
    }
}