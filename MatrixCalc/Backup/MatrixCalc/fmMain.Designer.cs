namespace MatrixCalc
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.gbMatrixAAbout = new System.Windows.Forms.GroupBox();
            this.bOkA = new System.Windows.Forms.Button();
            this.nudMatrixAColCount = new System.Windows.Forms.NumericUpDown();
            this.nudMatrixARowCount = new System.Windows.Forms.NumericUpDown();
            this.lbMatrixARowCount = new System.Windows.Forms.Label();
            this.lbMatrixAColCount = new System.Windows.Forms.Label();
            this.gbMatrixBAbout = new System.Windows.Forms.GroupBox();
            this.bOkB = new System.Windows.Forms.Button();
            this.nudMatrixBColCount = new System.Windows.Forms.NumericUpDown();
            this.nudMatrixBRowCount = new System.Windows.Forms.NumericUpDown();
            this.lbMatrixBRowCount = new System.Windows.Forms.Label();
            this.lbMatrixBColCount = new System.Windows.Forms.Label();
            this.gbResultAbout = new System.Windows.Forms.GroupBox();
            this.tbMatrixResultColCount = new System.Windows.Forms.TextBox();
            this.tbMatrixResultRowCount = new System.Windows.Forms.TextBox();
            this.lbMatrixResultRowCount = new System.Windows.Forms.Label();
            this.lbMatrixResultColCount = new System.Windows.Forms.Label();
            this.bResult = new System.Windows.Forms.Button();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.gbMatrixA = new System.Windows.Forms.GroupBox();
            this.tsA = new System.Windows.Forms.ToolStrip();
            this.tsbMrAToA = new System.Windows.Forms.ToolStripSplitButton();
            this.tsbMrResultToA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbMrBToA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMA = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCeA = new System.Windows.Forms.ToolStripButton();
            this.dgvMatrixA = new System.Windows.Forms.DataGridView();
            this.gbMatrixB = new System.Windows.Forms.GroupBox();
            this.tsB = new System.Windows.Forms.ToolStrip();
            this.tsbMrBToB = new System.Windows.Forms.ToolStripSplitButton();
            this.tsbMRrResultToB = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbMrAToB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCeB = new System.Windows.Forms.ToolStripButton();
            this.dgvMatrixB = new System.Windows.Forms.DataGridView();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.tsResult = new System.Windows.Forms.ToolStrip();
            this.tsbMrResultToResult = new System.Windows.Forms.ToolStripSplitButton();
            this.tsbMrBToResult = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbMrAToResult = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMResult = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCeResult = new System.Windows.Forms.ToolStripButton();
            this.dgvMatrixResult = new System.Windows.Forms.DataGridView();
            this.gbMatrixAAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatrixAColCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatrixARowCount)).BeginInit();
            this.gbMatrixBAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatrixBColCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatrixBRowCount)).BeginInit();
            this.gbResultAbout.SuspendLayout();
            this.gbMatrixA.SuspendLayout();
            this.tsA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixA)).BeginInit();
            this.gbMatrixB.SuspendLayout();
            this.tsB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixB)).BeginInit();
            this.gbResult.SuspendLayout();
            this.tsResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMatrixAAbout
            // 
            this.gbMatrixAAbout.Controls.Add(this.bOkA);
            this.gbMatrixAAbout.Controls.Add(this.nudMatrixAColCount);
            this.gbMatrixAAbout.Controls.Add(this.nudMatrixARowCount);
            this.gbMatrixAAbout.Controls.Add(this.lbMatrixARowCount);
            this.gbMatrixAAbout.Controls.Add(this.lbMatrixAColCount);
            this.gbMatrixAAbout.Location = new System.Drawing.Point(5, 7);
            this.gbMatrixAAbout.Name = "gbMatrixAAbout";
            this.gbMatrixAAbout.Size = new System.Drawing.Size(195, 90);
            this.gbMatrixAAbout.TabIndex = 0;
            this.gbMatrixAAbout.TabStop = false;
            this.gbMatrixAAbout.Text = "Матрица А";
            // 
            // bOkA
            // 
            this.bOkA.Location = new System.Drawing.Point(72, 62);
            this.bOkA.Name = "bOkA";
            this.bOkA.Size = new System.Drawing.Size(35, 23);
            this.bOkA.TabIndex = 2;
            this.bOkA.Text = "OK";
            this.bOkA.UseVisualStyleBackColor = true;
            this.bOkA.Click += new System.EventHandler(this.bOkA_Click);
            // 
            // nudMatrixAColCount
            // 
            this.nudMatrixAColCount.Location = new System.Drawing.Point(131, 36);
            this.nudMatrixAColCount.Name = "nudMatrixAColCount";
            this.nudMatrixAColCount.Size = new System.Drawing.Size(58, 20);
            this.nudMatrixAColCount.TabIndex = 1;
            // 
            // nudMatrixARowCount
            // 
            this.nudMatrixARowCount.Location = new System.Drawing.Point(131, 14);
            this.nudMatrixARowCount.Name = "nudMatrixARowCount";
            this.nudMatrixARowCount.Size = new System.Drawing.Size(58, 20);
            this.nudMatrixARowCount.TabIndex = 0;
            // 
            // lbMatrixARowCount
            // 
            this.lbMatrixARowCount.AutoSize = true;
            this.lbMatrixARowCount.Location = new System.Drawing.Point(6, 16);
            this.lbMatrixARowCount.Name = "lbMatrixARowCount";
            this.lbMatrixARowCount.Size = new System.Drawing.Size(101, 13);
            this.lbMatrixARowCount.TabIndex = 4;
            this.lbMatrixARowCount.Text = "Количество строк:";
            // 
            // lbMatrixAColCount
            // 
            this.lbMatrixAColCount.AutoSize = true;
            this.lbMatrixAColCount.Location = new System.Drawing.Point(6, 38);
            this.lbMatrixAColCount.Name = "lbMatrixAColCount";
            this.lbMatrixAColCount.Size = new System.Drawing.Size(119, 13);
            this.lbMatrixAColCount.TabIndex = 3;
            this.lbMatrixAColCount.Text = "Количество столбцов:";
            // 
            // gbMatrixBAbout
            // 
            this.gbMatrixBAbout.Controls.Add(this.bOkB);
            this.gbMatrixBAbout.Controls.Add(this.nudMatrixBColCount);
            this.gbMatrixBAbout.Controls.Add(this.nudMatrixBRowCount);
            this.gbMatrixBAbout.Controls.Add(this.lbMatrixBRowCount);
            this.gbMatrixBAbout.Controls.Add(this.lbMatrixBColCount);
            this.gbMatrixBAbout.Enabled = false;
            this.gbMatrixBAbout.Location = new System.Drawing.Point(259, 7);
            this.gbMatrixBAbout.Name = "gbMatrixBAbout";
            this.gbMatrixBAbout.Size = new System.Drawing.Size(195, 90);
            this.gbMatrixBAbout.TabIndex = 3;
            this.gbMatrixBAbout.TabStop = false;
            this.gbMatrixBAbout.Text = "Матрица B";
            // 
            // bOkB
            // 
            this.bOkB.Location = new System.Drawing.Point(72, 62);
            this.bOkB.Name = "bOkB";
            this.bOkB.Size = new System.Drawing.Size(35, 23);
            this.bOkB.TabIndex = 2;
            this.bOkB.Text = "OK";
            this.bOkB.UseVisualStyleBackColor = true;
            this.bOkB.Click += new System.EventHandler(this.bOkB_Click);
            // 
            // nudMatrixBColCount
            // 
            this.nudMatrixBColCount.Location = new System.Drawing.Point(131, 36);
            this.nudMatrixBColCount.Name = "nudMatrixBColCount";
            this.nudMatrixBColCount.Size = new System.Drawing.Size(58, 20);
            this.nudMatrixBColCount.TabIndex = 1;
            // 
            // nudMatrixBRowCount
            // 
            this.nudMatrixBRowCount.Location = new System.Drawing.Point(131, 14);
            this.nudMatrixBRowCount.Name = "nudMatrixBRowCount";
            this.nudMatrixBRowCount.Size = new System.Drawing.Size(58, 20);
            this.nudMatrixBRowCount.TabIndex = 0;
            // 
            // lbMatrixBRowCount
            // 
            this.lbMatrixBRowCount.AutoSize = true;
            this.lbMatrixBRowCount.Location = new System.Drawing.Point(6, 16);
            this.lbMatrixBRowCount.Name = "lbMatrixBRowCount";
            this.lbMatrixBRowCount.Size = new System.Drawing.Size(101, 13);
            this.lbMatrixBRowCount.TabIndex = 4;
            this.lbMatrixBRowCount.Text = "Количество строк:";
            // 
            // lbMatrixBColCount
            // 
            this.lbMatrixBColCount.AutoSize = true;
            this.lbMatrixBColCount.Location = new System.Drawing.Point(6, 38);
            this.lbMatrixBColCount.Name = "lbMatrixBColCount";
            this.lbMatrixBColCount.Size = new System.Drawing.Size(119, 13);
            this.lbMatrixBColCount.TabIndex = 3;
            this.lbMatrixBColCount.Text = "Количество столбцов:";
            // 
            // gbResultAbout
            // 
            this.gbResultAbout.Controls.Add(this.tbMatrixResultColCount);
            this.gbResultAbout.Controls.Add(this.tbMatrixResultRowCount);
            this.gbResultAbout.Controls.Add(this.lbMatrixResultRowCount);
            this.gbResultAbout.Controls.Add(this.lbMatrixResultColCount);
            this.gbResultAbout.Location = new System.Drawing.Point(498, 7);
            this.gbResultAbout.Name = "gbResultAbout";
            this.gbResultAbout.Size = new System.Drawing.Size(207, 90);
            this.gbResultAbout.TabIndex = 6;
            this.gbResultAbout.TabStop = false;
            this.gbResultAbout.Text = "Результат";
            // 
            // tbMatrixResultColCount
            // 
            this.tbMatrixResultColCount.Location = new System.Drawing.Point(131, 35);
            this.tbMatrixResultColCount.Name = "tbMatrixResultColCount";
            this.tbMatrixResultColCount.ReadOnly = true;
            this.tbMatrixResultColCount.Size = new System.Drawing.Size(70, 20);
            this.tbMatrixResultColCount.TabIndex = 6;
            // 
            // tbMatrixResultRowCount
            // 
            this.tbMatrixResultRowCount.Location = new System.Drawing.Point(131, 13);
            this.tbMatrixResultRowCount.Name = "tbMatrixResultRowCount";
            this.tbMatrixResultRowCount.ReadOnly = true;
            this.tbMatrixResultRowCount.Size = new System.Drawing.Size(70, 20);
            this.tbMatrixResultRowCount.TabIndex = 5;
            // 
            // lbMatrixResultRowCount
            // 
            this.lbMatrixResultRowCount.AutoSize = true;
            this.lbMatrixResultRowCount.Location = new System.Drawing.Point(6, 16);
            this.lbMatrixResultRowCount.Name = "lbMatrixResultRowCount";
            this.lbMatrixResultRowCount.Size = new System.Drawing.Size(101, 13);
            this.lbMatrixResultRowCount.TabIndex = 4;
            this.lbMatrixResultRowCount.Text = "Количество строк:";
            // 
            // lbMatrixResultColCount
            // 
            this.lbMatrixResultColCount.AutoSize = true;
            this.lbMatrixResultColCount.Location = new System.Drawing.Point(6, 38);
            this.lbMatrixResultColCount.Name = "lbMatrixResultColCount";
            this.lbMatrixResultColCount.Size = new System.Drawing.Size(119, 13);
            this.lbMatrixResultColCount.TabIndex = 3;
            this.lbMatrixResultColCount.Text = "Количество столбцов:";
            // 
            // bResult
            // 
            this.bResult.Location = new System.Drawing.Point(460, 157);
            this.bResult.Name = "bResult";
            this.bResult.Size = new System.Drawing.Size(29, 23);
            this.bResult.TabIndex = 5;
            this.bResult.Text = "=";
            this.bResult.UseVisualStyleBackColor = true;
            this.bResult.Click += new System.EventHandler(this.bResult_Click);
            // 
            // cbOperation
            // 
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Items.AddRange(new object[] {
            "+",
            "*",
            "A^(-1)"});
            this.cbOperation.Location = new System.Drawing.Point(200, 157);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(59, 21);
            this.cbOperation.TabIndex = 2;
            this.cbOperation.Text = "+";
            this.cbOperation.SelectedIndexChanged += new System.EventHandler(this.cbOperation_SelectedIndexChanged);
            // 
            // gbMatrixA
            // 
            this.gbMatrixA.Controls.Add(this.tsA);
            this.gbMatrixA.Controls.Add(this.dgvMatrixA);
            this.gbMatrixA.Location = new System.Drawing.Point(5, 98);
            this.gbMatrixA.Name = "gbMatrixA";
            this.gbMatrixA.Size = new System.Drawing.Size(195, 163);
            this.gbMatrixA.TabIndex = 1;
            this.gbMatrixA.TabStop = false;
            // 
            // tsA
            // 
            this.tsA.BackColor = System.Drawing.Color.Transparent;
            this.tsA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsA.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMrAToA,
            this.toolStripSeparator5,
            this.tsbMA,
            this.toolStripSeparator7,
            this.tsbCeA});
            this.tsA.Location = new System.Drawing.Point(3, 135);
            this.tsA.Name = "tsA";
            this.tsA.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsA.Size = new System.Drawing.Size(189, 25);
            this.tsA.TabIndex = 7;
            this.tsA.Text = "toolStrip2";
            // 
            // tsbMrAToA
            // 
            this.tsbMrAToA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMrAToA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMrResultToA,
            this.tsbMrBToA});
            this.tsbMrAToA.Image = ((System.Drawing.Image)(resources.GetObject("tsbMrAToA.Image")));
            this.tsbMrAToA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMrAToA.Name = "tsbMrAToA";
            this.tsbMrAToA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbMrAToA.Size = new System.Drawing.Size(52, 22);
            this.tsbMrAToA.Text = "MR A";
            this.tsbMrAToA.ToolTipText = "Вставить значения из буфера А в матрицу А";
            this.tsbMrAToA.Click += new System.EventHandler(this.tsbMrAToA_ButtonClick);
            // 
            // tsbMrResultToA
            // 
            this.tsbMrResultToA.Name = "tsbMrResultToA";
            this.tsbMrResultToA.Size = new System.Drawing.Size(148, 22);
            this.tsbMrResultToA.Text = "MR Результат";
            this.tsbMrResultToA.ToolTipText = "Вставить значения из буфера Результат в матрицу А";
            this.tsbMrResultToA.Click += new System.EventHandler(this.tsbMrResultToA_Click);
            // 
            // tsbMrBToA
            // 
            this.tsbMrBToA.Name = "tsbMrBToA";
            this.tsbMrBToA.Size = new System.Drawing.Size(148, 22);
            this.tsbMrBToA.Text = "MR B";
            this.tsbMrBToA.ToolTipText = "Вставить значения из буфера В в матрицу А";
            this.tsbMrBToA.Click += new System.EventHandler(this.tsbMrBToA_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbMA
            // 
            this.tsbMA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMA.Image = ((System.Drawing.Image)(resources.GetObject("tsbMA.Image")));
            this.tsbMA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMA.Name = "tsbMA";
            this.tsbMA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbMA.Size = new System.Drawing.Size(23, 22);
            this.tsbMA.Text = "M";
            this.tsbMA.ToolTipText = "Сохранить значения матрицы А в буфер А";
            this.tsbMA.Click += new System.EventHandler(this.tsbMA_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCeA
            // 
            this.tsbCeA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCeA.Image = ((System.Drawing.Image)(resources.GetObject("tsbCeA.Image")));
            this.tsbCeA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCeA.Name = "tsbCeA";
            this.tsbCeA.Size = new System.Drawing.Size(25, 22);
            this.tsbCeA.Text = "CE";
            this.tsbCeA.ToolTipText = "Отчистить матрицу А";
            this.tsbCeA.Click += new System.EventHandler(this.tsbCeA_Click);
            // 
            // dgvMatrixA
            // 
            this.dgvMatrixA.AllowUserToAddRows = false;
            this.dgvMatrixA.AllowUserToDeleteRows = false;
            this.dgvMatrixA.AllowUserToResizeRows = false;
            this.dgvMatrixA.ColumnHeadersVisible = false;
            this.dgvMatrixA.Location = new System.Drawing.Point(6, 19);
            this.dgvMatrixA.MultiSelect = false;
            this.dgvMatrixA.Name = "dgvMatrixA";
            this.dgvMatrixA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMatrixA.RowHeadersVisible = false;
            this.dgvMatrixA.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatrixA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMatrixA.ShowCellErrors = false;
            this.dgvMatrixA.ShowCellToolTips = false;
            this.dgvMatrixA.ShowEditingIcon = false;
            this.dgvMatrixA.ShowRowErrors = false;
            this.dgvMatrixA.Size = new System.Drawing.Size(183, 112);
            this.dgvMatrixA.TabIndex = 0;
            // 
            // gbMatrixB
            // 
            this.gbMatrixB.Controls.Add(this.tsB);
            this.gbMatrixB.Controls.Add(this.dgvMatrixB);
            this.gbMatrixB.Location = new System.Drawing.Point(259, 103);
            this.gbMatrixB.Name = "gbMatrixB";
            this.gbMatrixB.Size = new System.Drawing.Size(195, 158);
            this.gbMatrixB.TabIndex = 4;
            this.gbMatrixB.TabStop = false;
            // 
            // tsB
            // 
            this.tsB.BackColor = System.Drawing.Color.Transparent;
            this.tsB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsB.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMrBToB,
            this.toolStripSeparator4,
            this.tsbMB,
            this.toolStripSeparator3,
            this.tsbCeB});
            this.tsB.Location = new System.Drawing.Point(3, 130);
            this.tsB.Name = "tsB";
            this.tsB.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsB.Size = new System.Drawing.Size(189, 25);
            this.tsB.TabIndex = 6;
            this.tsB.Text = "toolStrip1";
            // 
            // tsbMrBToB
            // 
            this.tsbMrBToB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMrBToB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMRrResultToB,
            this.tsbMrAToB});
            this.tsbMrBToB.Image = ((System.Drawing.Image)(resources.GetObject("tsbMrBToB.Image")));
            this.tsbMrBToB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMrBToB.Name = "tsbMrBToB";
            this.tsbMrBToB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbMrBToB.Size = new System.Drawing.Size(51, 22);
            this.tsbMrBToB.Text = "MR B";
            this.tsbMrBToB.ToolTipText = "Вставить значения из буфера В в матрицу В";
            this.tsbMrBToB.Click += new System.EventHandler(this.tsbMrBToB_ButtonClick);
            // 
            // tsbMRrResultToB
            // 
            this.tsbMRrResultToB.Name = "tsbMRrResultToB";
            this.tsbMRrResultToB.Size = new System.Drawing.Size(152, 22);
            this.tsbMRrResultToB.Text = "MR Результат";
            this.tsbMRrResultToB.ToolTipText = "Вставить значения из буфера Результат в матрицу В";
            this.tsbMRrResultToB.Click += new System.EventHandler(this.tsbMrResultToB_Click);
            // 
            // tsbMrAToB
            // 
            this.tsbMrAToB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMrAToB.Name = "tsbMrAToB";
            this.tsbMrAToB.Size = new System.Drawing.Size(152, 22);
            this.tsbMrAToB.Text = "MR A";
            this.tsbMrAToB.ToolTipText = "Вставить значения из буфера А в матрицу В";
            this.tsbMrAToB.Click += new System.EventHandler(this.tsbMrAToB_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbMB
            // 
            this.tsbMB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMB.Image = ((System.Drawing.Image)(resources.GetObject("tsbMB.Image")));
            this.tsbMB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMB.Name = "tsbMB";
            this.tsbMB.Size = new System.Drawing.Size(23, 22);
            this.tsbMB.Text = "M";
            this.tsbMB.ToolTipText = "Сохранить значения матрицы В в буфер В";
            this.tsbMB.Click += new System.EventHandler(this.tsbMB_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCeB
            // 
            this.tsbCeB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCeB.Image = ((System.Drawing.Image)(resources.GetObject("tsbCeB.Image")));
            this.tsbCeB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCeB.Name = "tsbCeB";
            this.tsbCeB.Size = new System.Drawing.Size(25, 22);
            this.tsbCeB.Text = "CE";
            this.tsbCeB.ToolTipText = "Отчистить матрицу В";
            this.tsbCeB.Click += new System.EventHandler(this.tsbCeB_Click);
            // 
            // dgvMatrixB
            // 
            this.dgvMatrixB.AllowUserToAddRows = false;
            this.dgvMatrixB.AllowUserToDeleteRows = false;
            this.dgvMatrixB.AllowUserToResizeRows = false;
            this.dgvMatrixB.ColumnHeadersVisible = false;
            this.dgvMatrixB.Location = new System.Drawing.Point(6, 19);
            this.dgvMatrixB.MultiSelect = false;
            this.dgvMatrixB.Name = "dgvMatrixB";
            this.dgvMatrixB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMatrixB.RowHeadersVisible = false;
            this.dgvMatrixB.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatrixB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMatrixB.ShowCellErrors = false;
            this.dgvMatrixB.ShowCellToolTips = false;
            this.dgvMatrixB.ShowEditingIcon = false;
            this.dgvMatrixB.ShowRowErrors = false;
            this.dgvMatrixB.Size = new System.Drawing.Size(183, 107);
            this.dgvMatrixB.TabIndex = 0;
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.tsResult);
            this.gbResult.Controls.Add(this.dgvMatrixResult);
            this.gbResult.Location = new System.Drawing.Point(498, 103);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(207, 158);
            this.gbResult.TabIndex = 6;
            this.gbResult.TabStop = false;
            // 
            // tsResult
            // 
            this.tsResult.BackColor = System.Drawing.Color.Transparent;
            this.tsResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsResult.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMrResultToResult,
            this.toolStripSeparator9,
            this.tsbMResult,
            this.toolStripSeparator10,
            this.tsbCeResult});
            this.tsResult.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsResult.Location = new System.Drawing.Point(3, 132);
            this.tsResult.Name = "tsResult";
            this.tsResult.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsResult.Size = new System.Drawing.Size(201, 23);
            this.tsResult.TabIndex = 13;
            // 
            // tsbMrResultToResult
            // 
            this.tsbMrResultToResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMrResultToResult.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMrBToResult,
            this.tsbMrAToResult});
            this.tsbMrResultToResult.Image = ((System.Drawing.Image)(resources.GetObject("tsbMrResultToResult.Image")));
            this.tsbMrResultToResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMrResultToResult.Name = "tsbMrResultToResult";
            this.tsbMrResultToResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbMrResultToResult.Size = new System.Drawing.Size(97, 19);
            this.tsbMrResultToResult.Text = "MR Результат";
            this.tsbMrResultToResult.ToolTipText = "Вставить значения из буфера Результат в матрицу Результат";
            this.tsbMrResultToResult.Click += new System.EventHandler(this.tsbMrResultToResult_ButtonClick);
            // 
            // tsbMrBToResult
            // 
            this.tsbMrBToResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMrBToResult.Name = "tsbMrBToResult";
            this.tsbMrBToResult.Size = new System.Drawing.Size(152, 22);
            this.tsbMrBToResult.Text = "MR B";
            this.tsbMrBToResult.ToolTipText = "Вставить значения из буфера В в матрицу Результат";
            this.tsbMrBToResult.Click += new System.EventHandler(this.tsbMrBToResult_Click);
            // 
            // tsbMrAToResult
            // 
            this.tsbMrAToResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMrAToResult.Name = "tsbMrAToResult";
            this.tsbMrAToResult.Size = new System.Drawing.Size(152, 22);
            this.tsbMrAToResult.Text = "MR A";
            this.tsbMrAToResult.ToolTipText = "Вставить значения из буфера А в матрицу Результат";
            this.tsbMrAToResult.Click += new System.EventHandler(this.tsbMrAToResult_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbMResult
            // 
            this.tsbMResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMResult.Image = ((System.Drawing.Image)(resources.GetObject("tsbMResult.Image")));
            this.tsbMResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMResult.Name = "tsbMResult";
            this.tsbMResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbMResult.Size = new System.Drawing.Size(23, 19);
            this.tsbMResult.Text = "M";
            this.tsbMResult.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbMResult.ToolTipText = "Сохранить значения матрицы Результат в буфер Результат путем сложения";
            this.tsbMResult.Click += new System.EventHandler(this.tsbMResult_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbCeResult
            // 
            this.tsbCeResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCeResult.Image = ((System.Drawing.Image)(resources.GetObject("tsbCeResult.Image")));
            this.tsbCeResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCeResult.Name = "tsbCeResult";
            this.tsbCeResult.Size = new System.Drawing.Size(25, 19);
            this.tsbCeResult.Text = "CE";
            this.tsbCeResult.ToolTipText = "Отчистить матрицу Результат";
            this.tsbCeResult.Click += new System.EventHandler(this.tsbCeResult_Click);
            // 
            // dgvMatrixResult
            // 
            this.dgvMatrixResult.AllowUserToAddRows = false;
            this.dgvMatrixResult.AllowUserToDeleteRows = false;
            this.dgvMatrixResult.AllowUserToResizeRows = false;
            this.dgvMatrixResult.ColumnHeadersVisible = false;
            this.dgvMatrixResult.Location = new System.Drawing.Point(6, 19);
            this.dgvMatrixResult.MultiSelect = false;
            this.dgvMatrixResult.Name = "dgvMatrixResult";
            this.dgvMatrixResult.ReadOnly = true;
            this.dgvMatrixResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMatrixResult.RowHeadersVisible = false;
            this.dgvMatrixResult.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatrixResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMatrixResult.ShowCellErrors = false;
            this.dgvMatrixResult.ShowCellToolTips = false;
            this.dgvMatrixResult.ShowEditingIcon = false;
            this.dgvMatrixResult.ShowRowErrors = false;
            this.dgvMatrixResult.Size = new System.Drawing.Size(195, 107);
            this.dgvMatrixResult.TabIndex = 0;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 264);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbMatrixB);
            this.Controls.Add(this.gbMatrixA);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.bResult);
            this.Controls.Add(this.gbResultAbout);
            this.Controls.Add(this.gbMatrixBAbout);
            this.Controls.Add(this.gbMatrixAAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Матричный калькулятор";
            this.gbMatrixAAbout.ResumeLayout(false);
            this.gbMatrixAAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatrixAColCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatrixARowCount)).EndInit();
            this.gbMatrixBAbout.ResumeLayout(false);
            this.gbMatrixBAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatrixBColCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatrixBRowCount)).EndInit();
            this.gbResultAbout.ResumeLayout(false);
            this.gbResultAbout.PerformLayout();
            this.gbMatrixA.ResumeLayout(false);
            this.gbMatrixA.PerformLayout();
            this.tsA.ResumeLayout(false);
            this.tsA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixA)).EndInit();
            this.gbMatrixB.ResumeLayout(false);
            this.gbMatrixB.PerformLayout();
            this.tsB.ResumeLayout(false);
            this.tsB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixB)).EndInit();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.tsResult.ResumeLayout(false);
            this.tsResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMatrixAAbout;
        private System.Windows.Forms.Label lbMatrixARowCount;
        private System.Windows.Forms.Label lbMatrixAColCount;
        private System.Windows.Forms.GroupBox gbMatrixBAbout;
        private System.Windows.Forms.Label lbMatrixBRowCount;
        private System.Windows.Forms.Label lbMatrixBColCount;
        private System.Windows.Forms.GroupBox gbResultAbout;
        private System.Windows.Forms.TextBox tbMatrixResultColCount;
        private System.Windows.Forms.TextBox tbMatrixResultRowCount;
        private System.Windows.Forms.Label lbMatrixResultRowCount;
        private System.Windows.Forms.Label lbMatrixResultColCount;
        private System.Windows.Forms.Button bResult;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.NumericUpDown nudMatrixAColCount;
        private System.Windows.Forms.NumericUpDown nudMatrixARowCount;
        private System.Windows.Forms.NumericUpDown nudMatrixBColCount;
        private System.Windows.Forms.NumericUpDown nudMatrixBRowCount;
        private System.Windows.Forms.Button bOkA;
        private System.Windows.Forms.Button bOkB;
        private System.Windows.Forms.GroupBox gbMatrixA;
        private System.Windows.Forms.DataGridView dgvMatrixA;
        private System.Windows.Forms.GroupBox gbMatrixB;
        private System.Windows.Forms.DataGridView dgvMatrixB;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.DataGridView dgvMatrixResult;
        private System.Windows.Forms.ToolStrip tsB;
        private System.Windows.Forms.ToolStripSplitButton tsbMrBToB;
        private System.Windows.Forms.ToolStripButton tsbMB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbCeB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStrip tsA;
        private System.Windows.Forms.ToolStripSplitButton tsbMrAToA;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbMA;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbCeA;
        private System.Windows.Forms.ToolStrip tsResult;
        private System.Windows.Forms.ToolStripSplitButton tsbMrResultToResult;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton tsbMResult;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton tsbCeResult;
        private System.Windows.Forms.ToolStripMenuItem tsbMrResultToA;
        private System.Windows.Forms.ToolStripMenuItem tsbMrBToA;
        private System.Windows.Forms.ToolStripMenuItem tsbMRrResultToB;
        private System.Windows.Forms.ToolStripMenuItem tsbMrAToB;
        private System.Windows.Forms.ToolStripMenuItem tsbMrBToResult;
        private System.Windows.Forms.ToolStripMenuItem tsbMrAToResult;
    }
}

