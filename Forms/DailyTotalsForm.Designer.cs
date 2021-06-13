namespace MacroTracker.Forms
{
    partial class DailyTotalsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.breakfastFoodsView = new System.Windows.Forms.DataGridView();
            this.breakfastColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuButton = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.carbsLabel = new System.Windows.Forms.Label();
            this.proteinLabel = new System.Windows.Forms.Label();
            this.caloriesValue = new System.Windows.Forms.Label();
            this.fatValue = new System.Windows.Forms.Label();
            this.carbsValue = new System.Windows.Forms.Label();
            this.proteinValue = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.lunchFoodsView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinnerFoodsView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snackFoodsView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastFoodsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchFoodsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerFoodsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snackFoodsView)).BeginInit();
            this.SuspendLayout();
            // 
            // breakfastFoodsView
            // 
            this.breakfastFoodsView.AllowUserToAddRows = false;
            this.breakfastFoodsView.AllowUserToDeleteRows = false;
            this.breakfastFoodsView.AllowUserToResizeColumns = false;
            this.breakfastFoodsView.AllowUserToResizeRows = false;
            this.breakfastFoodsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.breakfastFoodsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.breakfastFoodsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.breakfastFoodsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.breakfastColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.breakfastFoodsView.DefaultCellStyle = dataGridViewCellStyle2;
            this.breakfastFoodsView.Location = new System.Drawing.Point(9, 169);
            this.breakfastFoodsView.Margin = new System.Windows.Forms.Padding(2);
            this.breakfastFoodsView.Name = "breakfastFoodsView";
            this.breakfastFoodsView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.breakfastFoodsView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.breakfastFoodsView.RowHeadersVisible = false;
            this.breakfastFoodsView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.breakfastFoodsView.RowTemplate.Height = 24;
            this.breakfastFoodsView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.breakfastFoodsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.breakfastFoodsView.Size = new System.Drawing.Size(330, 284);
            this.breakfastFoodsView.TabIndex = 0;
            // 
            // breakfastColumn
            // 
            this.breakfastColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.breakfastColumn.HeaderText = "Breakfast";
            this.breakfastColumn.Name = "breakfastColumn";
            this.breakfastColumn.ReadOnly = true;
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(615, 576);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(109, 39);
            this.menuButton.TabIndex = 22;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.CustomFormat = "M/dd/yyyy";
            this.datePicker.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(622, 116);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowUpDown = true;
            this.datePicker.Size = new System.Drawing.Size(180, 39);
            this.datePicker.TabIndex = 39;
            this.datePicker.Value = new System.DateTime(2021, 6, 10, 0, 29, 20, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(536, 118);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(81, 32);
            this.dateLabel.TabIndex = 38;
            this.dateLabel.Text = "Date:";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesLabel.Location = new System.Drawing.Point(117, 503);
            this.caloriesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(123, 32);
            this.caloriesLabel.TabIndex = 41;
            this.caloriesLabel.Text = "Calories:";
            this.caloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatLabel.Location = new System.Drawing.Point(449, 503);
            this.fatLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(63, 32);
            this.fatLabel.TabIndex = 42;
            this.fatLabel.Text = "Fat:";
            this.fatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carbsLabel
            // 
            this.carbsLabel.AutoSize = true;
            this.carbsLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbsLabel.Location = new System.Drawing.Point(721, 503);
            this.carbsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carbsLabel.Name = "carbsLabel";
            this.carbsLabel.Size = new System.Drawing.Size(96, 32);
            this.carbsLabel.TabIndex = 43;
            this.carbsLabel.Text = "Carbs:";
            this.carbsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // proteinLabel
            // 
            this.proteinLabel.AutoSize = true;
            this.proteinLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinLabel.Location = new System.Drawing.Point(1026, 503);
            this.proteinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.proteinLabel.Name = "proteinLabel";
            this.proteinLabel.Size = new System.Drawing.Size(108, 32);
            this.proteinLabel.TabIndex = 44;
            this.proteinLabel.Text = "Protein:";
            this.proteinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caloriesValue
            // 
            this.caloriesValue.AutoSize = true;
            this.caloriesValue.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesValue.Location = new System.Drawing.Point(244, 503);
            this.caloriesValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.caloriesValue.Name = "caloriesValue";
            this.caloriesValue.Size = new System.Drawing.Size(75, 32);
            this.caloriesValue.TabIndex = 45;
            this.caloriesValue.Text = "1234";
            this.caloriesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fatValue
            // 
            this.fatValue.AutoSize = true;
            this.fatValue.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatValue.Location = new System.Drawing.Point(516, 503);
            this.fatValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fatValue.Name = "fatValue";
            this.fatValue.Size = new System.Drawing.Size(83, 32);
            this.fatValue.TabIndex = 46;
            this.fatValue.Text = "123.4";
            this.fatValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carbsValue
            // 
            this.carbsValue.AutoSize = true;
            this.carbsValue.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbsValue.Location = new System.Drawing.Point(821, 503);
            this.carbsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carbsValue.Name = "carbsValue";
            this.carbsValue.Size = new System.Drawing.Size(83, 32);
            this.carbsValue.TabIndex = 47;
            this.carbsValue.Text = "123.4";
            this.carbsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // proteinValue
            // 
            this.proteinValue.AutoSize = true;
            this.proteinValue.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinValue.Location = new System.Drawing.Point(1138, 503);
            this.proteinValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.proteinValue.Name = "proteinValue";
            this.proteinValue.Size = new System.Drawing.Size(83, 32);
            this.proteinValue.TabIndex = 48;
            this.proteinValue.Text = "123.4";
            this.proteinValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(361, 9);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(616, 79);
            this.title.TabIndex = 40;
            this.title.Text = "Daily Totals";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lunchFoodsView
            // 
            this.lunchFoodsView.AllowUserToAddRows = false;
            this.lunchFoodsView.AllowUserToDeleteRows = false;
            this.lunchFoodsView.AllowUserToResizeColumns = false;
            this.lunchFoodsView.AllowUserToResizeRows = false;
            this.lunchFoodsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lunchFoodsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.lunchFoodsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lunchFoodsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lunchFoodsView.DefaultCellStyle = dataGridViewCellStyle5;
            this.lunchFoodsView.Location = new System.Drawing.Point(339, 169);
            this.lunchFoodsView.Margin = new System.Windows.Forms.Padding(2);
            this.lunchFoodsView.Name = "lunchFoodsView";
            this.lunchFoodsView.ReadOnly = true;
            this.lunchFoodsView.RowHeadersVisible = false;
            this.lunchFoodsView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lunchFoodsView.RowTemplate.Height = 24;
            this.lunchFoodsView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lunchFoodsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lunchFoodsView.Size = new System.Drawing.Size(330, 284);
            this.lunchFoodsView.TabIndex = 49;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Lunch";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dinnerFoodsView
            // 
            this.dinnerFoodsView.AllowUserToAddRows = false;
            this.dinnerFoodsView.AllowUserToDeleteRows = false;
            this.dinnerFoodsView.AllowUserToResizeColumns = false;
            this.dinnerFoodsView.AllowUserToResizeRows = false;
            this.dinnerFoodsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dinnerFoodsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dinnerFoodsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dinnerFoodsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dinnerFoodsView.DefaultCellStyle = dataGridViewCellStyle7;
            this.dinnerFoodsView.Location = new System.Drawing.Point(669, 169);
            this.dinnerFoodsView.Margin = new System.Windows.Forms.Padding(2);
            this.dinnerFoodsView.Name = "dinnerFoodsView";
            this.dinnerFoodsView.ReadOnly = true;
            this.dinnerFoodsView.RowHeadersVisible = false;
            this.dinnerFoodsView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dinnerFoodsView.RowTemplate.Height = 24;
            this.dinnerFoodsView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dinnerFoodsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dinnerFoodsView.Size = new System.Drawing.Size(330, 284);
            this.dinnerFoodsView.TabIndex = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Dinner";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // snackFoodsView
            // 
            this.snackFoodsView.AllowUserToAddRows = false;
            this.snackFoodsView.AllowUserToDeleteRows = false;
            this.snackFoodsView.AllowUserToResizeColumns = false;
            this.snackFoodsView.AllowUserToResizeRows = false;
            this.snackFoodsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.snackFoodsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.snackFoodsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.snackFoodsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.snackFoodsView.DefaultCellStyle = dataGridViewCellStyle9;
            this.snackFoodsView.Location = new System.Drawing.Point(999, 169);
            this.snackFoodsView.Margin = new System.Windows.Forms.Padding(2);
            this.snackFoodsView.Name = "snackFoodsView";
            this.snackFoodsView.ReadOnly = true;
            this.snackFoodsView.RowHeadersVisible = false;
            this.snackFoodsView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.snackFoodsView.RowTemplate.Height = 24;
            this.snackFoodsView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.snackFoodsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.snackFoodsView.Size = new System.Drawing.Size(330, 284);
            this.snackFoodsView.TabIndex = 51;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Snack";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // DailyTotalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 626);
            this.Controls.Add(this.snackFoodsView);
            this.Controls.Add(this.dinnerFoodsView);
            this.Controls.Add(this.lunchFoodsView);
            this.Controls.Add(this.proteinValue);
            this.Controls.Add(this.carbsValue);
            this.Controls.Add(this.fatValue);
            this.Controls.Add(this.caloriesValue);
            this.Controls.Add(this.proteinLabel);
            this.Controls.Add(this.carbsLabel);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.breakfastFoodsView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DailyTotalsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MacroTracker - Daily Totals";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DailyTotalsForm_FormClosed);
            this.Shown += new System.EventHandler(this.DailyTotalsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.breakfastFoodsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchFoodsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerFoodsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snackFoodsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView breakfastFoodsView;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label carbsLabel;
        private System.Windows.Forms.Label proteinLabel;
        private System.Windows.Forms.Label caloriesValue;
        private System.Windows.Forms.Label fatValue;
        private System.Windows.Forms.Label carbsValue;
        private System.Windows.Forms.Label proteinValue;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakfastColumn;
        private System.Windows.Forms.DataGridView lunchFoodsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dinnerFoodsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView snackFoodsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}