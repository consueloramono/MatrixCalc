namespace MatrixCalc
{
    partial class fmMain
    {
        private System.ComponentModel.IContainer components = null;

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
            this.dgvMatrixA = new System.Windows.Forms.DataGridView();
            this.gbMatrixB = new System.Windows.Forms.GroupBox();
            this.dgvMatrixB = new System.Windows.Forms.DataGridView();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.dgvMatrixResult = new System.Windows.Forms.DataGridView();
            this.tsbCeA = new System.Windows.Forms.ToolStripButton();
            this.tsA = new System.Windows.Forms.ToolStrip();
            this.tsbCeB = new System.Windows.Forms.ToolStripButton();
            this.tsB = new System.Windows.Forms.ToolStrip();
            this.tsbCeResult = new System.Windows.Forms.ToolStripButton();
            this.tsResult = new System.Windows.Forms.ToolStrip();
            this.gbMatrixAAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatrixAColCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatrixARowCount)).BeginInit();
            this.gbMatrixBAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatrixBColCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatrixBRowCount)).BeginInit();
            this.gbResultAbout.SuspendLayout();
            this.gbMatrixA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixA)).BeginInit();
            this.gbMatrixB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixB)).BeginInit();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixResult)).BeginInit();
            this.tsA.SuspendLayout();
            this.tsB.SuspendLayout();
            this.tsResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMatrixAAbout
            // 
            this.gbMatrixAAbout.Controls.Add(this.bOkA);
            this.gbMatrixAAbout.Controls.Add(this.nudMatrixAColCount);
            this.gbMatrixAAbout.Controls.Add(this.nudMatrixARowCount);
            this.gbMatrixAAbout.Controls.Add(this.lbMatrixARowCount);
            this.gbMatrixAAbout.Controls.Add(this.lbMatrixAColCount);
            this.gbMatrixAAbout.Location = new System.Drawing.Point(7, 9);
            this.gbMatrixAAbout.Margin = new System.Windows.Forms.Padding(4);
            this.gbMatrixAAbout.Name = "gbMatrixAAbout";
            this.gbMatrixAAbout.Padding = new System.Windows.Forms.Padding(4);
            this.gbMatrixAAbout.Size = new System.Drawing.Size(260, 111);
            this.gbMatrixAAbout.TabIndex = 0;
            this.gbMatrixAAbout.TabStop = false;
            this.gbMatrixAAbout.Text = "Матриця А";
            // 
            // bOkA
            // 
            this.bOkA.Location = new System.Drawing.Point(96, 76);
            this.bOkA.Margin = new System.Windows.Forms.Padding(4);
            this.bOkA.Name = "bOkA";
            this.bOkA.Size = new System.Drawing.Size(47, 28);
            this.bOkA.TabIndex = 2;
            this.bOkA.Text = "OK";
            this.bOkA.UseVisualStyleBackColor = true;
            this.bOkA.Click += new System.EventHandler(this.bOkA_Click);
            // 
            // nudMatrixAColCount
            // 
            this.nudMatrixAColCount.Location = new System.Drawing.Point(175, 44);
            this.nudMatrixAColCount.Margin = new System.Windows.Forms.Padding(4);
            this.nudMatrixAColCount.Name = "nudMatrixAColCount";
            this.nudMatrixAColCount.Size = new System.Drawing.Size(77, 22);
            this.nudMatrixAColCount.TabIndex = 1;
            // 
            // nudMatrixARowCount
            // 
            this.nudMatrixARowCount.Location = new System.Drawing.Point(175, 17);
            this.nudMatrixARowCount.Margin = new System.Windows.Forms.Padding(4);
            this.nudMatrixARowCount.Name = "nudMatrixARowCount";
            this.nudMatrixARowCount.Size = new System.Drawing.Size(77, 22);
            this.nudMatrixARowCount.TabIndex = 0;
            // 
            // lbMatrixARowCount
            // 
            this.lbMatrixARowCount.AutoSize = true;
            this.lbMatrixARowCount.Location = new System.Drawing.Point(8, 20);
            this.lbMatrixARowCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatrixARowCount.Name = "lbMatrixARowCount";
            this.lbMatrixARowCount.Size = new System.Drawing.Size(119, 17);
            this.lbMatrixARowCount.TabIndex = 4;
            this.lbMatrixARowCount.Text = "Кількість рядків: ";
            // 
            // lbMatrixAColCount
            // 
            this.lbMatrixAColCount.AutoSize = true;
            this.lbMatrixAColCount.Location = new System.Drawing.Point(8, 47);
            this.lbMatrixAColCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatrixAColCount.Name = "lbMatrixAColCount";
            this.lbMatrixAColCount.Size = new System.Drawing.Size(133, 17);
            this.lbMatrixAColCount.TabIndex = 3;
            this.lbMatrixAColCount.Text = "Кількість стовпців: ";
            // 
            // gbMatrixBAbout
            // 
            this.gbMatrixBAbout.Controls.Add(this.bOkB);
            this.gbMatrixBAbout.Controls.Add(this.nudMatrixBColCount);
            this.gbMatrixBAbout.Controls.Add(this.nudMatrixBRowCount);
            this.gbMatrixBAbout.Controls.Add(this.lbMatrixBRowCount);
            this.gbMatrixBAbout.Controls.Add(this.lbMatrixBColCount);
            this.gbMatrixBAbout.Enabled = false;
            this.gbMatrixBAbout.Location = new System.Drawing.Point(345, 9);
            this.gbMatrixBAbout.Margin = new System.Windows.Forms.Padding(4);
            this.gbMatrixBAbout.Name = "gbMatrixBAbout";
            this.gbMatrixBAbout.Padding = new System.Windows.Forms.Padding(4);
            this.gbMatrixBAbout.Size = new System.Drawing.Size(260, 111);
            this.gbMatrixBAbout.TabIndex = 3;
            this.gbMatrixBAbout.TabStop = false;
            this.gbMatrixBAbout.Text = "Матриця B";
            // 
            // bOkB
            // 
            this.bOkB.Location = new System.Drawing.Point(96, 76);
            this.bOkB.Margin = new System.Windows.Forms.Padding(4);
            this.bOkB.Name = "bOkB";
            this.bOkB.Size = new System.Drawing.Size(47, 28);
            this.bOkB.TabIndex = 2;
            this.bOkB.Text = "OK";
            this.bOkB.UseVisualStyleBackColor = true;
            this.bOkB.Click += new System.EventHandler(this.bOkB_Click);
            // 
            // nudMatrixBColCount
            // 
            this.nudMatrixBColCount.Location = new System.Drawing.Point(175, 44);
            this.nudMatrixBColCount.Margin = new System.Windows.Forms.Padding(4);
            this.nudMatrixBColCount.Name = "nudMatrixBColCount";
            this.nudMatrixBColCount.Size = new System.Drawing.Size(77, 22);
            this.nudMatrixBColCount.TabIndex = 1;
            // 
            // nudMatrixBRowCount
            // 
            this.nudMatrixBRowCount.Location = new System.Drawing.Point(175, 17);
            this.nudMatrixBRowCount.Margin = new System.Windows.Forms.Padding(4);
            this.nudMatrixBRowCount.Name = "nudMatrixBRowCount";
            this.nudMatrixBRowCount.Size = new System.Drawing.Size(77, 22);
            this.nudMatrixBRowCount.TabIndex = 0;
            // 
            // lbMatrixBRowCount
            // 
            this.lbMatrixBRowCount.AutoSize = true;
            this.lbMatrixBRowCount.Location = new System.Drawing.Point(8, 20);
            this.lbMatrixBRowCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatrixBRowCount.Name = "lbMatrixBRowCount";
            this.lbMatrixBRowCount.Size = new System.Drawing.Size(119, 17);
            this.lbMatrixBRowCount.TabIndex = 4;
            this.lbMatrixBRowCount.Text = "Кількість рядків: ";
            // 
            // lbMatrixBColCount
            // 
            this.lbMatrixBColCount.AutoSize = true;
            this.lbMatrixBColCount.Location = new System.Drawing.Point(8, 47);
            this.lbMatrixBColCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatrixBColCount.Name = "lbMatrixBColCount";
            this.lbMatrixBColCount.Size = new System.Drawing.Size(133, 17);
            this.lbMatrixBColCount.TabIndex = 3;
            this.lbMatrixBColCount.Text = "Кількість стовпців: ";
            // 
            // gbResultAbout
            // 
            this.gbResultAbout.Controls.Add(this.tbMatrixResultColCount);
            this.gbResultAbout.Controls.Add(this.tbMatrixResultRowCount);
            this.gbResultAbout.Controls.Add(this.lbMatrixResultRowCount);
            this.gbResultAbout.Controls.Add(this.lbMatrixResultColCount);
            this.gbResultAbout.Location = new System.Drawing.Point(664, 9);
            this.gbResultAbout.Margin = new System.Windows.Forms.Padding(4);
            this.gbResultAbout.Name = "gbResultAbout";
            this.gbResultAbout.Padding = new System.Windows.Forms.Padding(4);
            this.gbResultAbout.Size = new System.Drawing.Size(276, 111);
            this.gbResultAbout.TabIndex = 6;
            this.gbResultAbout.TabStop = false;
            this.gbResultAbout.Text = "Результат";
            // 
            // tbMatrixResultColCount
            // 
            this.tbMatrixResultColCount.Location = new System.Drawing.Point(175, 43);
            this.tbMatrixResultColCount.Margin = new System.Windows.Forms.Padding(4);
            this.tbMatrixResultColCount.Name = "tbMatrixResultColCount";
            this.tbMatrixResultColCount.ReadOnly = true;
            this.tbMatrixResultColCount.Size = new System.Drawing.Size(92, 22);
            this.tbMatrixResultColCount.TabIndex = 6;
            // 
            // tbMatrixResultRowCount
            // 
            this.tbMatrixResultRowCount.Location = new System.Drawing.Point(175, 16);
            this.tbMatrixResultRowCount.Margin = new System.Windows.Forms.Padding(4);
            this.tbMatrixResultRowCount.Name = "tbMatrixResultRowCount";
            this.tbMatrixResultRowCount.ReadOnly = true;
            this.tbMatrixResultRowCount.Size = new System.Drawing.Size(92, 22);
            this.tbMatrixResultRowCount.TabIndex = 5;
            // 
            // lbMatrixResultRowCount
            // 
            this.lbMatrixResultRowCount.AutoSize = true;
            this.lbMatrixResultRowCount.Location = new System.Drawing.Point(8, 20);
            this.lbMatrixResultRowCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatrixResultRowCount.Name = "lbMatrixResultRowCount";
            this.lbMatrixResultRowCount.Size = new System.Drawing.Size(119, 17);
            this.lbMatrixResultRowCount.TabIndex = 4;
            this.lbMatrixResultRowCount.Text = "Кількість рядків: ";
            // 
            // lbMatrixResultColCount
            // 
            this.lbMatrixResultColCount.AutoSize = true;
            this.lbMatrixResultColCount.Location = new System.Drawing.Point(8, 47);
            this.lbMatrixResultColCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatrixResultColCount.Name = "lbMatrixResultColCount";
            this.lbMatrixResultColCount.Size = new System.Drawing.Size(133, 17);
            this.lbMatrixResultColCount.TabIndex = 3;
            this.lbMatrixResultColCount.Text = "Кількість стовпців: ";
            // 
            // bResult
            // 
            this.bResult.Location = new System.Drawing.Point(613, 193);
            this.bResult.Margin = new System.Windows.Forms.Padding(4);
            this.bResult.Name = "bResult";
            this.bResult.Size = new System.Drawing.Size(39, 28);
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
            this.cbOperation.Location = new System.Drawing.Point(267, 193);
            this.cbOperation.Margin = new System.Windows.Forms.Padding(4);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(77, 24);
            this.cbOperation.TabIndex = 2;
            this.cbOperation.Text = "+";
            this.cbOperation.SelectedIndexChanged += new System.EventHandler(this.cbOperation_SelectedIndexChanged);
            // 
            // gbMatrixA
            // 
            this.gbMatrixA.Controls.Add(this.tsA);
            this.gbMatrixA.Controls.Add(this.dgvMatrixA);
            this.gbMatrixA.Location = new System.Drawing.Point(7, 121);
            this.gbMatrixA.Margin = new System.Windows.Forms.Padding(4);
            this.gbMatrixA.Name = "gbMatrixA";
            this.gbMatrixA.Padding = new System.Windows.Forms.Padding(4);
            this.gbMatrixA.Size = new System.Drawing.Size(260, 201);
            this.gbMatrixA.TabIndex = 1;
            this.gbMatrixA.TabStop = false;
            // 
            // dgvMatrixA
            // 
            this.dgvMatrixA.AllowUserToAddRows = false;
            this.dgvMatrixA.AllowUserToDeleteRows = false;
            this.dgvMatrixA.AllowUserToResizeRows = false;
            this.dgvMatrixA.ColumnHeadersHeight = 29;
            this.dgvMatrixA.ColumnHeadersVisible = false;
            this.dgvMatrixA.Location = new System.Drawing.Point(8, 23);
            this.dgvMatrixA.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMatrixA.MultiSelect = false;
            this.dgvMatrixA.Name = "dgvMatrixA";
            this.dgvMatrixA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMatrixA.RowHeadersVisible = false;
            this.dgvMatrixA.RowHeadersWidth = 51;
            this.dgvMatrixA.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatrixA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMatrixA.ShowCellErrors = false;
            this.dgvMatrixA.ShowCellToolTips = false;
            this.dgvMatrixA.ShowEditingIcon = false;
            this.dgvMatrixA.ShowRowErrors = false;
            this.dgvMatrixA.Size = new System.Drawing.Size(244, 138);
            this.dgvMatrixA.TabIndex = 0;
            // 
            // gbMatrixB
            // 
            this.gbMatrixB.Controls.Add(this.tsB);
            this.gbMatrixB.Controls.Add(this.dgvMatrixB);
            this.gbMatrixB.Location = new System.Drawing.Point(345, 127);
            this.gbMatrixB.Margin = new System.Windows.Forms.Padding(4);
            this.gbMatrixB.Name = "gbMatrixB";
            this.gbMatrixB.Padding = new System.Windows.Forms.Padding(4);
            this.gbMatrixB.Size = new System.Drawing.Size(260, 194);
            this.gbMatrixB.TabIndex = 4;
            this.gbMatrixB.TabStop = false;
            // 
            // dgvMatrixB
            // 
            this.dgvMatrixB.AllowUserToAddRows = false;
            this.dgvMatrixB.AllowUserToDeleteRows = false;
            this.dgvMatrixB.AllowUserToResizeRows = false;
            this.dgvMatrixB.ColumnHeadersHeight = 29;
            this.dgvMatrixB.ColumnHeadersVisible = false;
            this.dgvMatrixB.Location = new System.Drawing.Point(8, 23);
            this.dgvMatrixB.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMatrixB.MultiSelect = false;
            this.dgvMatrixB.Name = "dgvMatrixB";
            this.dgvMatrixB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMatrixB.RowHeadersVisible = false;
            this.dgvMatrixB.RowHeadersWidth = 51;
            this.dgvMatrixB.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatrixB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMatrixB.ShowCellErrors = false;
            this.dgvMatrixB.ShowCellToolTips = false;
            this.dgvMatrixB.ShowEditingIcon = false;
            this.dgvMatrixB.ShowRowErrors = false;
            this.dgvMatrixB.Size = new System.Drawing.Size(244, 132);
            this.dgvMatrixB.TabIndex = 0;
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.tsResult);
            this.gbResult.Controls.Add(this.dgvMatrixResult);
            this.gbResult.Location = new System.Drawing.Point(664, 127);
            this.gbResult.Margin = new System.Windows.Forms.Padding(4);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(4);
            this.gbResult.Size = new System.Drawing.Size(276, 194);
            this.gbResult.TabIndex = 6;
            this.gbResult.TabStop = false;
            // 
            // dgvMatrixResult
            // 
            this.dgvMatrixResult.AllowUserToAddRows = false;
            this.dgvMatrixResult.AllowUserToDeleteRows = false;
            this.dgvMatrixResult.AllowUserToResizeRows = false;
            this.dgvMatrixResult.ColumnHeadersHeight = 29;
            this.dgvMatrixResult.ColumnHeadersVisible = false;
            this.dgvMatrixResult.Location = new System.Drawing.Point(8, 23);
            this.dgvMatrixResult.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMatrixResult.MultiSelect = false;
            this.dgvMatrixResult.Name = "dgvMatrixResult";
            this.dgvMatrixResult.ReadOnly = true;
            this.dgvMatrixResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMatrixResult.RowHeadersVisible = false;
            this.dgvMatrixResult.RowHeadersWidth = 51;
            this.dgvMatrixResult.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatrixResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMatrixResult.ShowCellErrors = false;
            this.dgvMatrixResult.ShowCellToolTips = false;
            this.dgvMatrixResult.ShowEditingIcon = false;
            this.dgvMatrixResult.ShowRowErrors = false;
            this.dgvMatrixResult.Size = new System.Drawing.Size(260, 132);
            this.dgvMatrixResult.TabIndex = 0;
            // 
            // tsbCeA
            // 
            this.tsbCeA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCeA.Image = ((System.Drawing.Image)(resources.GetObject("tsbCeA.Image")));
            this.tsbCeA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCeA.Name = "tsbCeA";
            this.tsbCeA.Size = new System.Drawing.Size(30, 24);
            this.tsbCeA.Text = "CE";
            this.tsbCeA.ToolTipText = "Отчистити матрицю Результат";
            this.tsbCeA.Click += new System.EventHandler(this.tsbCeA_Click);
            // 
            // tsA
            // 
            this.tsA.BackColor = System.Drawing.Color.Transparent;
            this.tsA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsA.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsA.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCeA});
            this.tsA.Location = new System.Drawing.Point(4, 170);
            this.tsA.Name = "tsA";
            this.tsA.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsA.Size = new System.Drawing.Size(252, 27);
            this.tsA.TabIndex = 7;
            this.tsA.Text = "toolStrip2";
            // 
            // tsbCeB
            // 
            this.tsbCeB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCeB.Image = ((System.Drawing.Image)(resources.GetObject("tsbCeB.Image")));
            this.tsbCeB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCeB.Name = "tsbCeB";
            this.tsbCeB.Size = new System.Drawing.Size(30, 24);
            this.tsbCeB.Text = "CE";
            this.tsbCeB.ToolTipText = "Отчистити матрицю Результат";
            this.tsbCeB.Click += new System.EventHandler(this.tsbCeB_Click);
            // 
            // tsB
            // 
            this.tsB.BackColor = System.Drawing.Color.Transparent;
            this.tsB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsB.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsB.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCeB});
            this.tsB.Location = new System.Drawing.Point(4, 163);
            this.tsB.Name = "tsB";
            this.tsB.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsB.Size = new System.Drawing.Size(252, 27);
            this.tsB.TabIndex = 6;
            this.tsB.Text = "toolStrip1";
            // 
            // tsbCeResult
            // 
            this.tsbCeResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCeResult.Image = ((System.Drawing.Image)(resources.GetObject("tsbCeResult.Image")));
            this.tsbCeResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCeResult.Name = "tsbCeResult";
            this.tsbCeResult.Size = new System.Drawing.Size(30, 24);
            this.tsbCeResult.Text = "CE";
            this.tsbCeResult.ToolTipText = "Отчистити матрицю Результат";
            this.tsbCeResult.Click += new System.EventHandler(this.tsbCeResult_Click);
            // 
            // tsResult
            // 
            this.tsResult.BackColor = System.Drawing.Color.Transparent;
            this.tsResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsResult.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsResult.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCeResult});
            this.tsResult.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsResult.Location = new System.Drawing.Point(4, 163);
            this.tsResult.Name = "tsResult";
            this.tsResult.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsResult.Size = new System.Drawing.Size(268, 27);
            this.tsResult.TabIndex = 13;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 325);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbMatrixB);
            this.Controls.Add(this.gbMatrixA);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.bResult);
            this.Controls.Add(this.gbResultAbout);
            this.Controls.Add(this.gbMatrixBAbout);
            this.Controls.Add(this.gbMatrixAAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Матричний калькулятор";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixA)).EndInit();
            this.gbMatrixB.ResumeLayout(false);
            this.gbMatrixB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixB)).EndInit();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixResult)).EndInit();
            this.tsA.ResumeLayout(false);
            this.tsA.PerformLayout();
            this.tsB.ResumeLayout(false);
            this.tsB.PerformLayout();
            this.tsResult.ResumeLayout(false);
            this.tsResult.PerformLayout();
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
        private System.Windows.Forms.ToolStrip tsA;
        private System.Windows.Forms.ToolStripButton tsbCeA;
        private System.Windows.Forms.ToolStrip tsB;
        private System.Windows.Forms.ToolStripButton tsbCeB;
        private System.Windows.Forms.ToolStrip tsResult;
        private System.Windows.Forms.ToolStripButton tsbCeResult;
    }
}

