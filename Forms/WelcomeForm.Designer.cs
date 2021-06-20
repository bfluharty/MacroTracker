namespace MacroTracker.Forms
{
    partial class WelcomeForm
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
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.getStartedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(9, 9);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(782, 157);
            this.title.TabIndex = 19;
            this.title.Text = "Welcome to MacroTracker!";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(782, 157);
            this.label1.TabIndex = 20;
            this.label1.Text = "Since this is your first time using MacroTracker, please enter your daily macro g" +
    "oals.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // getStartedButton
            // 
            this.getStartedButton.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStartedButton.Location = new System.Drawing.Point(191, 349);
            this.getStartedButton.Name = "getStartedButton";
            this.getStartedButton.Size = new System.Drawing.Size(419, 66);
            this.getStartedButton.TabIndex = 21;
            this.getStartedButton.Text = "Let\'s Get Started!";
            this.getStartedButton.UseVisualStyleBackColor = true;
            this.getStartedButton.Click += new System.EventHandler(this.getStartedButton_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getStartedButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MacroTracker - Welcome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WelcomeForm_FormClosed);
            this.Shown += new System.EventHandler(this.WelcomeForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getStartedButton;
    }
}