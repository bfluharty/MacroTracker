namespace MacroTracker.Forms
{
    partial class ReviewNewMealForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.title = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.mealToAddGrid = new System.Windows.Forms.DataGridView();
            this.foodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servingsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mealToAddGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(220, 7);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(469, 54);
            this.title.TabIndex = 0;
            this.title.Text = "Meal To Be Added";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(571, 547);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(109, 39);
            this.submitButton.TabIndex = 19;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(400, 547);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(109, 39);
            this.backButton.TabIndex = 20;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(229, 547);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(109, 39);
            this.menuButton.TabIndex = 21;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // mealToAddGrid
            // 
            this.mealToAddGrid.AllowUserToResizeColumns = false;
            this.mealToAddGrid.AllowUserToResizeRows = false;
            this.mealToAddGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mealToAddGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mealToAddGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mealToAddGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mealToAddGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodColumn,
            this.servingsColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mealToAddGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.mealToAddGrid.Location = new System.Drawing.Point(9, 210);
            this.mealToAddGrid.Margin = new System.Windows.Forms.Padding(2);
            this.mealToAddGrid.Name = "mealToAddGrid";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mealToAddGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mealToAddGrid.RowHeadersVisible = false;
            this.mealToAddGrid.RowTemplate.Height = 24;
            this.mealToAddGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mealToAddGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mealToAddGrid.Size = new System.Drawing.Size(890, 298);
            this.mealToAddGrid.TabIndex = 22;
            this.mealToAddGrid.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.foodsToAddGrid_ColumnAdded);
            // 
            // foodColumn
            // 
            this.foodColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.foodColumn.FillWeight = 98.47716F;
            this.foodColumn.HeaderText = "Food";
            this.foodColumn.Name = "foodColumn";
            this.foodColumn.ReadOnly = true;
            // 
            // servingsColumn
            // 
            this.servingsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.servingsColumn.FillWeight = 101.5228F;
            this.servingsColumn.HeaderText = "Servings";
            this.servingsColumn.Name = "servingsColumn";
            this.servingsColumn.ReadOnly = true;
            this.servingsColumn.Width = 109;
            // 
            // mealLabel
            // 
            this.mealLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealLabel.Location = new System.Drawing.Point(205, 114);
            this.mealLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(498, 32);
            this.mealLabel.TabIndex = 42;
            this.mealLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReviewNewMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 635);
            this.Controls.Add(this.mealLabel);
            this.Controls.Add(this.mealToAddGrid);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReviewNewMealForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MacroTracker - Confirm New Meal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReviewNewMealForm_FormClosed);
            this.Shown += new System.EventHandler(this.ReviewNewMealForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.mealToAddGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.DataGridView mealToAddGrid;
        private System.Windows.Forms.BindingSource foodBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servingsColumn;
        private System.Windows.Forms.Label mealLabel;
    }
}