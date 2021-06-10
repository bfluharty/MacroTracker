namespace MacroTracker.Forms
{
    partial class MenuForm
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
            this.addFoodButton = new System.Windows.Forms.Button();
            this.recordMealButton = new System.Windows.Forms.Button();
            this.viewRecordsButton = new System.Windows.Forms.Button();
            this.viewFoodsButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addFoodButton
            // 
            this.addFoodButton.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFoodButton.Location = new System.Drawing.Point(134, 309);
            this.addFoodButton.Margin = new System.Windows.Forms.Padding(4);
            this.addFoodButton.Name = "addFoodButton";
            this.addFoodButton.Size = new System.Drawing.Size(654, 101);
            this.addFoodButton.TabIndex = 4;
            this.addFoodButton.Text = "Add New Food";
            this.addFoodButton.UseVisualStyleBackColor = true;
            this.addFoodButton.Click += new System.EventHandler(this.addFoodButton_Click);
            // 
            // recordMealButton
            // 
            this.recordMealButton.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordMealButton.Location = new System.Drawing.Point(134, 183);
            this.recordMealButton.Margin = new System.Windows.Forms.Padding(4);
            this.recordMealButton.Name = "recordMealButton";
            this.recordMealButton.Size = new System.Drawing.Size(654, 101);
            this.recordMealButton.TabIndex = 6;
            this.recordMealButton.Text = "Record Meal";
            this.recordMealButton.UseVisualStyleBackColor = true;
            this.recordMealButton.Click += new System.EventHandler(this.recordMealButton_Click);
            // 
            // viewRecordsButton
            // 
            this.viewRecordsButton.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRecordsButton.Location = new System.Drawing.Point(134, 435);
            this.viewRecordsButton.Margin = new System.Windows.Forms.Padding(4);
            this.viewRecordsButton.Name = "viewRecordsButton";
            this.viewRecordsButton.Size = new System.Drawing.Size(654, 101);
            this.viewRecordsButton.TabIndex = 7;
            this.viewRecordsButton.Text = "View Records";
            this.viewRecordsButton.UseVisualStyleBackColor = true;
            this.viewRecordsButton.Click += new System.EventHandler(this.viewRecordsButton_Click);
            // 
            // viewFoodsButton
            // 
            this.viewFoodsButton.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFoodsButton.Location = new System.Drawing.Point(134, 561);
            this.viewFoodsButton.Margin = new System.Windows.Forms.Padding(4);
            this.viewFoodsButton.Name = "viewFoodsButton";
            this.viewFoodsButton.Size = new System.Drawing.Size(654, 101);
            this.viewFoodsButton.TabIndex = 8;
            this.viewFoodsButton.Text = "View Foods";
            this.viewFoodsButton.UseVisualStyleBackColor = true;
            this.viewFoodsButton.Click += new System.EventHandler(this.viewFoodsButton_Click);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.title.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(899, 139);
            this.title.TabIndex = 5;
            this.title.Text = "MacroTracker";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 709);
            this.Controls.Add(this.viewFoodsButton);
            this.Controls.Add(this.viewRecordsButton);
            this.Controls.Add(this.recordMealButton);
            this.Controls.Add(this.title);
            this.Controls.Add(this.addFoodButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MacroTracker - Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addFoodButton;
        private System.Windows.Forms.Button recordMealButton;
        private System.Windows.Forms.Button viewRecordsButton;
        private System.Windows.Forms.Button viewFoodsButton;
        private System.Windows.Forms.Label title;
    }
}

