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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewNewMealForm));
            this.title = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.mealToAddGrid = new System.Windows.Forms.DataGridView();
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealLabel = new System.Windows.Forms.Label();
            this.foodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servingsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editMealColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.removeMealColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mealToAddGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(93, 9);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(581, 75);
            this.title.TabIndex = 0;
            this.title.Text = "Meal To Be Added";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(494, 547);
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
            this.backButton.Location = new System.Drawing.Point(323, 547);
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
            this.menuButton.Location = new System.Drawing.Point(152, 546);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(109, 39);
            this.menuButton.TabIndex = 21;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // mealToAddGrid
            // 
            this.mealToAddGrid.AllowUserToAddRows = false;
            this.mealToAddGrid.AllowUserToResizeColumns = false;
            this.mealToAddGrid.AllowUserToResizeRows = false;
            this.mealToAddGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mealToAddGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mealToAddGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mealToAddGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mealToAddGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodColumn,
            this.servingsColumn,
            this.editMealColumn,
            this.removeMealColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mealToAddGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.mealToAddGrid.Location = new System.Drawing.Point(95, 205);
            this.mealToAddGrid.Margin = new System.Windows.Forms.Padding(2);
            this.mealToAddGrid.Name = "mealToAddGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mealToAddGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mealToAddGrid.RowHeadersVisible = false;
            this.mealToAddGrid.RowTemplate.Height = 24;
            this.mealToAddGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mealToAddGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mealToAddGrid.Size = new System.Drawing.Size(565, 298);
            this.mealToAddGrid.TabIndex = 22;
            this.mealToAddGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mealToAddGrid_CellContentClick);
            this.mealToAddGrid.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.foodsToAddGrid_ColumnAdded);
            // 
            // mealLabel
            // 
            this.mealLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealLabel.Location = new System.Drawing.Point(95, 117);
            this.mealLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(565, 55);
            this.mealLabel.TabIndex = 42;
            this.mealLabel.Text = "Breakfast - 6/12/2021";
            this.mealLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodColumn
            // 
            this.foodColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.foodColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.foodColumn.FillWeight = 122.4885F;
            this.foodColumn.HeaderText = "Food";
            this.foodColumn.Name = "foodColumn";
            this.foodColumn.ReadOnly = true;
            this.foodColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // servingsColumn
            // 
            this.servingsColumn.FillWeight = 2.202557F;
            this.servingsColumn.HeaderText = "Servings";
            this.servingsColumn.MinimumWidth = 120;
            this.servingsColumn.Name = "servingsColumn";
            this.servingsColumn.ReadOnly = true;
            this.servingsColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // editMealColumn
            // 
            this.editMealColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editMealColumn.FillWeight = 31.92091F;
            this.editMealColumn.HeaderText = "";
            this.editMealColumn.MinimumWidth = 40;
            this.editMealColumn.Name = "editMealColumn";
            this.editMealColumn.Text = "e";
            this.editMealColumn.UseColumnTextForButtonValue = true;
            this.editMealColumn.Width = 40;
            // 
            // removeMealColumn
            // 
            this.removeMealColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.removeMealColumn.FillWeight = 64.02489F;
            this.removeMealColumn.HeaderText = "";
            this.removeMealColumn.MinimumWidth = 40;
            this.removeMealColumn.Name = "removeMealColumn";
            this.removeMealColumn.Text = "x";
            this.removeMealColumn.UseColumnTextForButtonValue = true;
            this.removeMealColumn.Width = 40;
            // 
            // ReviewNewMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 635);
            this.Controls.Add(this.mealLabel);
            this.Controls.Add(this.mealToAddGrid);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReviewNewMealForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MacroTracker - Confirm New Meal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReviewNewMealForm_FormClosed);
            this.Shown += new System.EventHandler(this.ReviewNewMealForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.mealToAddGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.DataGridView mealToAddGrid;
        private System.Windows.Forms.BindingSource foodBindingSource;
        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servingsColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editMealColumn;
        private System.Windows.Forms.DataGridViewButtonColumn removeMealColumn;
    }
}