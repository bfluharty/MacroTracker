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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.addFoodButton = new System.Windows.Forms.Button();
            this.recordMealButton = new System.Windows.Forms.Button();
            this.viewRecordsButton = new System.Windows.Forms.Button();
            this.viewFoodsButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.editGoalsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addFoodButton
            // 
            this.addFoodButton.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFoodButton.Location = new System.Drawing.Point(100, 212);
            this.addFoodButton.Name = "addFoodButton";
            this.addFoodButton.Size = new System.Drawing.Size(490, 66);
            this.addFoodButton.TabIndex = 4;
            this.addFoodButton.Text = "Add New Food";
            this.addFoodButton.UseVisualStyleBackColor = true;
            this.addFoodButton.Click += new System.EventHandler(this.addFoodButton_Click);
            // 
            // recordMealButton
            // 
            this.recordMealButton.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordMealButton.Location = new System.Drawing.Point(100, 123);
            this.recordMealButton.Name = "recordMealButton";
            this.recordMealButton.Size = new System.Drawing.Size(490, 66);
            this.recordMealButton.TabIndex = 6;
            this.recordMealButton.Text = "Record Meal";
            this.recordMealButton.UseVisualStyleBackColor = true;
            this.recordMealButton.Click += new System.EventHandler(this.recordMealButton_Click);
            // 
            // viewRecordsButton
            // 
            this.viewRecordsButton.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRecordsButton.Location = new System.Drawing.Point(100, 301);
            this.viewRecordsButton.Name = "viewRecordsButton";
            this.viewRecordsButton.Size = new System.Drawing.Size(490, 66);
            this.viewRecordsButton.TabIndex = 7;
            this.viewRecordsButton.Text = "View Records";
            this.viewRecordsButton.UseVisualStyleBackColor = true;
            this.viewRecordsButton.Click += new System.EventHandler(this.viewRecordsButton_Click);
            // 
            // viewFoodsButton
            // 
            this.viewFoodsButton.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFoodsButton.Location = new System.Drawing.Point(100, 390);
            this.viewFoodsButton.Name = "viewFoodsButton";
            this.viewFoodsButton.Size = new System.Drawing.Size(490, 66);
            this.viewFoodsButton.TabIndex = 8;
            this.viewFoodsButton.Text = "View Foods";
            this.viewFoodsButton.UseVisualStyleBackColor = true;
            this.viewFoodsButton.Click += new System.EventHandler(this.viewFoodsButton_Click);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.title.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(9, 7);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(674, 113);
            this.title.TabIndex = 5;
            this.title.Text = "MacroTracker";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editGoalsButton
            // 
            this.editGoalsButton.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editGoalsButton.Location = new System.Drawing.Point(100, 482);
            this.editGoalsButton.Name = "editGoalsButton";
            this.editGoalsButton.Size = new System.Drawing.Size(490, 66);
            this.editGoalsButton.TabIndex = 9;
            this.editGoalsButton.Text = "Set Goals";
            this.editGoalsButton.UseVisualStyleBackColor = true;
            this.editGoalsButton.Click += new System.EventHandler(this.editGoalsButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 576);
            this.Controls.Add(this.editGoalsButton);
            this.Controls.Add(this.viewFoodsButton);
            this.Controls.Add(this.viewRecordsButton);
            this.Controls.Add(this.recordMealButton);
            this.Controls.Add(this.title);
            this.Controls.Add(this.addFoodButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MacroTracker - Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.Shown += new System.EventHandler(this.MenuForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addFoodButton;
        private System.Windows.Forms.Button recordMealButton;
        private System.Windows.Forms.Button viewRecordsButton;
        private System.Windows.Forms.Button viewFoodsButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button editGoalsButton;
    }
}

