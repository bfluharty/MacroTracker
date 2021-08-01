namespace MacroTracker.Forms
{
    partial class SavedFoodsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavedFoodsForm));
            this.savedFoodsView = new System.Windows.Forms.DataGridView();
            this.menuButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.foodLabel = new System.Windows.Forms.Label();
            this.foodBox = new System.Windows.Forms.TextBox();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaloriesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarbsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProteinColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditFoodColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RemoveFoodColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.savedFoodsView)).BeginInit();
            this.SuspendLayout();
            // 
            // savedFoodsView
            // 
            this.savedFoodsView.AllowUserToAddRows = false;
            this.savedFoodsView.AllowUserToDeleteRows = false;
            this.savedFoodsView.AllowUserToResizeColumns = false;
            this.savedFoodsView.AllowUserToResizeRows = false;
            this.savedFoodsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.savedFoodsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.savedFoodsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.savedFoodsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.CaloriesColumn,
            this.FatColumn,
            this.CarbsColumn,
            this.ProteinColumn,
            this.EditFoodColumn,
            this.RemoveFoodColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.savedFoodsView.DefaultCellStyle = dataGridViewCellStyle3;
            this.savedFoodsView.Location = new System.Drawing.Point(87, 148);
            this.savedFoodsView.Margin = new System.Windows.Forms.Padding(2);
            this.savedFoodsView.Name = "savedFoodsView";
            this.savedFoodsView.ReadOnly = true;
            this.savedFoodsView.RowHeadersVisible = false;
            this.savedFoodsView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.savedFoodsView.RowTemplate.Height = 24;
            this.savedFoodsView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.savedFoodsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.savedFoodsView.Size = new System.Drawing.Size(839, 407);
            this.savedFoodsView.TabIndex = 0;
            this.savedFoodsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.savedFoodsView_CellContentClick);
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(452, 575);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(109, 39);
            this.menuButton.TabIndex = 22;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(272, 9);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(469, 75);
            this.title.TabIndex = 23;
            this.title.Text = "Saved Foods";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel.Location = new System.Drawing.Point(278, 100);
            this.foodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(85, 32);
            this.foodLabel.TabIndex = 44;
            this.foodLabel.Text = "Food:";
            this.foodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodBox
            // 
            this.foodBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.foodBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.foodBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodBox.Location = new System.Drawing.Point(368, 97);
            this.foodBox.Name = "foodBox";
            this.foodBox.Size = new System.Drawing.Size(366, 39);
            this.foodBox.TabIndex = 45;
            this.foodBox.TextChanged += new System.EventHandler(this.foodBox_TextChanged);
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NameColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CaloriesColumn
            // 
            this.CaloriesColumn.HeaderText = "Calories";
            this.CaloriesColumn.Name = "CaloriesColumn";
            this.CaloriesColumn.ReadOnly = true;
            this.CaloriesColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CaloriesColumn.Width = 120;
            // 
            // FatColumn
            // 
            this.FatColumn.HeaderText = "Fat";
            this.FatColumn.Name = "FatColumn";
            this.FatColumn.ReadOnly = true;
            this.FatColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CarbsColumn
            // 
            this.CarbsColumn.HeaderText = "Carbs";
            this.CarbsColumn.Name = "CarbsColumn";
            this.CarbsColumn.ReadOnly = true;
            this.CarbsColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProteinColumn
            // 
            this.ProteinColumn.HeaderText = "Protein";
            this.ProteinColumn.Name = "ProteinColumn";
            this.ProteinColumn.ReadOnly = true;
            this.ProteinColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProteinColumn.Width = 120;
            // 
            // EditFoodColumn
            // 
            this.EditFoodColumn.HeaderText = "";
            this.EditFoodColumn.MinimumWidth = 40;
            this.EditFoodColumn.Name = "EditFoodColumn";
            this.EditFoodColumn.ReadOnly = true;
            this.EditFoodColumn.Text = "e";
            this.EditFoodColumn.UseColumnTextForButtonValue = true;
            this.EditFoodColumn.Width = 40;
            // 
            // RemoveFoodColumn
            // 
            this.RemoveFoodColumn.HeaderText = "";
            this.RemoveFoodColumn.MinimumWidth = 40;
            this.RemoveFoodColumn.Name = "RemoveFoodColumn";
            this.RemoveFoodColumn.ReadOnly = true;
            this.RemoveFoodColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RemoveFoodColumn.Text = "x";
            this.RemoveFoodColumn.UseColumnTextForButtonValue = true;
            this.RemoveFoodColumn.Width = 40;
            // 
            // SavedFoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 626);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.foodBox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.savedFoodsView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SavedFoodsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MacroTracker - Saved Foods";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SavedFoodsForm_FormClosed);
            this.Shown += new System.EventHandler(this.SavedFoodsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.savedFoodsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView savedFoodsView;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.TextBox foodBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaloriesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarbsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProteinColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditFoodColumn;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveFoodColumn;
    }
}