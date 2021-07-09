namespace MacroTracker.Forms
{
    partial class ReviewNewFoodForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewNewFoodForm));
            this.title = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.foodsToAddGrid = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteinColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editFoodColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.removeFoodColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.foodsToAddGrid)).BeginInit();
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
            this.title.Text = "Foods To Be Added";
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
            // foodsToAddGrid
            // 
            this.foodsToAddGrid.AllowUserToAddRows = false;
            this.foodsToAddGrid.AllowUserToResizeColumns = false;
            this.foodsToAddGrid.AllowUserToResizeRows = false;
            this.foodsToAddGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.foodsToAddGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodsToAddGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.foodsToAddGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodsToAddGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.caloriesColumn,
            this.fatColumn,
            this.carbsColumn,
            this.proteinColumn,
            this.editFoodColumn,
            this.removeFoodColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.foodsToAddGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.foodsToAddGrid.Location = new System.Drawing.Point(9, 64);
            this.foodsToAddGrid.Margin = new System.Windows.Forms.Padding(2);
            this.foodsToAddGrid.Name = "foodsToAddGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodsToAddGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.foodsToAddGrid.RowHeadersVisible = false;
            this.foodsToAddGrid.RowTemplate.Height = 24;
            this.foodsToAddGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.foodsToAddGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodsToAddGrid.Size = new System.Drawing.Size(890, 444);
            this.foodsToAddGrid.TabIndex = 22;
            this.foodsToAddGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodsToAddGrid_CellContentClick);
            this.foodsToAddGrid.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.foodsToAddGrid_ColumnAdded);
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nameColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nameColumn.FillWeight = 1000F;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.MinimumWidth = 100;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // caloriesColumn
            // 
            this.caloriesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.caloriesColumn.FillWeight = 1000F;
            this.caloriesColumn.HeaderText = "Calories";
            this.caloriesColumn.MinimumWidth = 120;
            this.caloriesColumn.Name = "caloriesColumn";
            this.caloriesColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.caloriesColumn.Width = 120;
            // 
            // fatColumn
            // 
            this.fatColumn.FillWeight = 11F;
            this.fatColumn.HeaderText = "Fat";
            this.fatColumn.MinimumWidth = 100;
            this.fatColumn.Name = "fatColumn";
            this.fatColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // carbsColumn
            // 
            this.carbsColumn.FillWeight = 43.86742F;
            this.carbsColumn.HeaderText = "Carbs";
            this.carbsColumn.MinimumWidth = 100;
            this.carbsColumn.Name = "carbsColumn";
            this.carbsColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // proteinColumn
            // 
            this.proteinColumn.HeaderText = "Protein";
            this.proteinColumn.MinimumWidth = 120;
            this.proteinColumn.Name = "proteinColumn";
            this.proteinColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // editFoodColumn
            // 
            this.editFoodColumn.HeaderText = "";
            this.editFoodColumn.MinimumWidth = 40;
            this.editFoodColumn.Name = "editFoodColumn";
            this.editFoodColumn.Text = "e";
            this.editFoodColumn.UseColumnTextForButtonValue = true;
            // 
            // removeFoodColumn
            // 
            this.removeFoodColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.removeFoodColumn.HeaderText = "";
            this.removeFoodColumn.MinimumWidth = 40;
            this.removeFoodColumn.Name = "removeFoodColumn";
            this.removeFoodColumn.Text = "x";
            this.removeFoodColumn.UseColumnTextForButtonValue = true;
            this.removeFoodColumn.Width = 40;
            // 
            // ReviewNewFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 635);
            this.Controls.Add(this.foodsToAddGrid);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReviewNewFoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MacroTracker - Confirm New Food";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReviewNewFoodForm_FormClosed);
            this.Shown += new System.EventHandler(this.ReviewNewFoodForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.foodsToAddGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.DataGridView foodsToAddGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carbsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteinColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editFoodColumn;
        private System.Windows.Forms.DataGridViewButtonColumn removeFoodColumn;
    }
}