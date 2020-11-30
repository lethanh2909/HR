namespace HR
{
    partial class fSalaryCalculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSalaryCalculation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvSummary = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnLoad = new DevComponents.DotNetBar.ButtonX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DatePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DatePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbbDep = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbbPos = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.dtgvEmployee = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.dtgvOT = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dtgvAll = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSummary)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAll)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvSummary
            // 
            this.dtgvSummary.AllowUserToAddRows = false;
            this.dtgvSummary.AllowUserToDeleteRows = false;
            this.dtgvSummary.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvSummary.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvSummary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgvSummary.Location = new System.Drawing.Point(294, 43);
            this.dtgvSummary.Name = "dtgvSummary";
            this.dtgvSummary.ReadOnly = true;
            this.dtgvSummary.Size = new System.Drawing.Size(742, 72);
            this.dtgvSummary.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLoad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(12, 483);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(276, 40);
            this.btnLoad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(12, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 72);
            this.panel3.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DatePickerFrom);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 32);
            this.panel1.TabIndex = 17;
            // 
            // DatePickerFrom
            // 
            this.DatePickerFrom.CustomFormat = "dd/MM/yyyy";
            this.DatePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerFrom.Location = new System.Drawing.Point(96, 5);
            this.DatePickerFrom.Name = "DatePickerFrom";
            this.DatePickerFrom.Size = new System.Drawing.Size(170, 21);
            this.DatePickerFrom.TabIndex = 1;
            this.DatePickerFrom.Value = new System.DateTime(2019, 11, 1, 0, 0, 0, 0);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(40, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "From:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DatePickerTo);
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Location = new System.Drawing.Point(3, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 32);
            this.panel2.TabIndex = 18;
            // 
            // DatePickerTo
            // 
            this.DatePickerTo.CustomFormat = "dd/MM/yyyy";
            this.DatePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerTo.Location = new System.Drawing.Point(96, 5);
            this.DatePickerTo.Name = "DatePickerTo";
            this.DatePickerTo.Size = new System.Drawing.Size(170, 21);
            this.DatePickerTo.TabIndex = 1;
            this.DatePickerTo.Value = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(3, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(28, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "To:";
            // 
            // cbbMonth
            // 
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Location = new System.Drawing.Point(85, 19);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(41, 21);
            this.cbbMonth.TabIndex = 21;
            // 
            // cbbYear
            // 
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(183, 19);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(76, 21);
            this.cbbYear.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Location = new System.Drawing.Point(12, 121);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(276, 76);
            this.panel6.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbbDep);
            this.panel4.Controls.Add(this.labelX6);
            this.panel4.Location = new System.Drawing.Point(3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 32);
            this.panel4.TabIndex = 8;
            // 
            // cbbDep
            // 
            this.cbbDep.DisplayMember = "Text";
            this.cbbDep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.ItemHeight = 15;
            this.cbbDep.Location = new System.Drawing.Point(96, 5);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(167, 21);
            this.cbbDep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbDep.TabIndex = 1;
            this.cbbDep.SelectedIndexChanged += new System.EventHandler(this.cbbDep_SelectedIndexChanged);
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(3, 3);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(87, 23);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Department:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbbPos);
            this.panel5.Controls.Add(this.labelX7);
            this.panel5.Location = new System.Drawing.Point(3, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 32);
            this.panel5.TabIndex = 9;
            // 
            // cbbPos
            // 
            this.cbbPos.DisplayMember = "Text";
            this.cbbPos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPos.FormattingEnabled = true;
            this.cbbPos.ItemHeight = 15;
            this.cbbPos.Location = new System.Drawing.Point(96, 5);
            this.cbbPos.Name = "cbbPos";
            this.cbbPos.Size = new System.Drawing.Size(167, 21);
            this.cbbPos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbPos.TabIndex = 1;
            this.cbbPos.SelectedIndexChanged += new System.EventHandler(this.cbbPos_SelectedIndexChanged);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(3, 3);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(87, 23);
            this.labelX7.TabIndex = 0;
            this.labelX7.Text = "Position:";
            // 
            // dtgvEmployee
            // 
            this.dtgvEmployee.AllowUserToAddRows = false;
            this.dtgvEmployee.AllowUserToDeleteRows = false;
            this.dtgvEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgvEmployee.Location = new System.Drawing.Point(12, 203);
            this.dtgvEmployee.Name = "dtgvEmployee";
            this.dtgvEmployee.ReadOnly = true;
            this.dtgvEmployee.Size = new System.Drawing.Size(276, 273);
            this.dtgvEmployee.TabIndex = 29;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(37, 18);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(47, 23);
            this.labelX3.TabIndex = 31;
            this.labelX3.Text = "Month:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(142, 18);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(41, 23);
            this.labelX4.TabIndex = 32;
            this.labelX4.Text = "Year:";
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDelete.Location = new System.Drawing.Point(1054, 43);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 72);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtgvOT
            // 
            this.dtgvOT.AllowUserToAddRows = false;
            this.dtgvOT.AllowUserToDeleteRows = false;
            this.dtgvOT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvOT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvOT.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvOT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgvOT.Location = new System.Drawing.Point(294, 129);
            this.dtgvOT.Name = "dtgvOT";
            this.dtgvOT.Size = new System.Drawing.Size(350, 93);
            this.dtgvOT.TabIndex = 37;
            // 
            // dtgvAll
            // 
            this.dtgvAll.AllowUserToAddRows = false;
            this.dtgvAll.AllowUserToDeleteRows = false;
            this.dtgvAll.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvAll.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvAll.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgvAll.Location = new System.Drawing.Point(294, 240);
            this.dtgvAll.Name = "dtgvAll";
            this.dtgvAll.Size = new System.Drawing.Size(350, 101);
            this.dtgvAll.TabIndex = 38;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(755, 143);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(140, 23);
            this.labelX5.TabIndex = 39;
            this.labelX5.Text = "Salary: 4600000";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(734, 172);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(140, 23);
            this.labelX8.TabIndex = 40;
            this.labelX8.Text = "Overtime: 170000";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(727, 201);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(140, 23);
            this.labelX9.TabIndex = 41;
            this.labelX9.Text = "Allowance: 350000";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(717, 230);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(140, 23);
            this.labelX10.TabIndex = 42;
            this.labelX10.Text = "Adjustment: 0";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(719, 260);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 10);
            this.panel7.TabIndex = 43;
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.Location = new System.Drawing.Point(764, 276);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(140, 23);
            this.labelX11.TabIndex = 44;
            this.labelX11.Text = "Total: 5120000";
            // 
            // fSalaryCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 534);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.dtgvAll);
            this.Controls.Add(this.dtgvOT);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.dtgvEmployee);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.cbbYear);
            this.Controls.Add(this.cbbMonth);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtgvSummary);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fSalaryCalculation";
            this.Text = "fSalaryCalculation";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSummary)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgvSummary;
        private DevComponents.DotNetBar.ButtonX btnLoad;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DatePickerFrom;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DatePickerTo;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbDep;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbPos;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgvEmployee;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgvOT;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgvAll;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.Panel panel7;
        private DevComponents.DotNetBar.LabelX labelX11;
    }
}