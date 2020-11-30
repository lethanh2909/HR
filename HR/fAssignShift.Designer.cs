namespace HR
{
    partial class fAssignShift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAssignShift));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvShiftEmployee = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbShift = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnAssign = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DatePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DatePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnUnassign = new DevComponents.DotNetBar.ButtonX();
            this.btnShow = new DevComponents.DotNetBar.ButtonX();
            this.ckbOnly = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbbPos = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbDep = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtgvEmployee = new DevComponents.DotNetBar.Controls.DataGridViewX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShiftEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvShiftEmployee
            // 
            this.dtgvShiftEmployee.AllowUserToAddRows = false;
            this.dtgvShiftEmployee.AllowUserToDeleteRows = false;
            this.dtgvShiftEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvShiftEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvShiftEmployee.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvShiftEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgvShiftEmployee.Location = new System.Drawing.Point(598, 118);
            this.dtgvShiftEmployee.Name = "dtgvShiftEmployee";
            this.dtgvShiftEmployee.ReadOnly = true;
            this.dtgvShiftEmployee.Size = new System.Drawing.Size(500, 404);
            this.dtgvShiftEmployee.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbShift);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(598, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 32);
            this.panel1.TabIndex = 11;
            // 
            // cbbShift
            // 
            this.cbbShift.DisplayMember = "Text";
            this.cbbShift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbShift.FormattingEnabled = true;
            this.cbbShift.ItemHeight = 15;
            this.cbbShift.Items.AddRange(new object[] {
            this.comboItem1});
            this.cbbShift.Location = new System.Drawing.Point(79, 5);
            this.cbbShift.Name = "cbbShift";
            this.cbbShift.Size = new System.Drawing.Size(190, 21);
            this.cbbShift.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbShift.TabIndex = 1;
            this.cbbShift.SelectedIndexChanged += new System.EventHandler(this.cbbShift_SelectedIndexChanged);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "comboItem1";
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
            this.labelX1.Size = new System.Drawing.Size(80, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Shift name:";
            // 
            // btnAssign
            // 
            this.btnAssign.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAssign.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAssign.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.Image = ((System.Drawing.Image)(resources.GetObject("btnAssign.Image")));
            this.btnAssign.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAssign.Location = new System.Drawing.Point(322, 273);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(237, 41);
            this.btnAssign.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAssign.TabIndex = 12;
            this.btnAssign.Text = "Assign shift          ";
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DatePickerFrom);
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Location = new System.Drawing.Point(322, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 32);
            this.panel2.TabIndex = 19;
            // 
            // DatePickerFrom
            // 
            this.DatePickerFrom.CustomFormat = "dd/MM/yyyy";
            this.DatePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerFrom.Location = new System.Drawing.Point(77, 5);
            this.DatePickerFrom.Name = "DatePickerFrom";
            this.DatePickerFrom.Size = new System.Drawing.Size(157, 21);
            this.DatePickerFrom.TabIndex = 1;
            this.DatePickerFrom.Value = new System.DateTime(2020, 11, 15, 0, 0, 0, 0);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(11, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(40, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Start:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DatePickerTo);
            this.panel4.Controls.Add(this.labelX3);
            this.panel4.Location = new System.Drawing.Point(322, 235);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 32);
            this.panel4.TabIndex = 20;
            // 
            // DatePickerTo
            // 
            this.DatePickerTo.CustomFormat = "dd/MM/yyyy";
            this.DatePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerTo.Location = new System.Drawing.Point(77, 5);
            this.DatePickerTo.Name = "DatePickerTo";
            this.DatePickerTo.Size = new System.Drawing.Size(157, 21);
            this.DatePickerTo.TabIndex = 1;
            this.DatePickerTo.Value = new System.DateTime(2020, 11, 15, 0, 0, 0, 0);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(11, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(28, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "End:";
            // 
            // btnUnassign
            // 
            this.btnUnassign.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUnassign.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUnassign.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnassign.Location = new System.Drawing.Point(1023, 80);
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.Size = new System.Drawing.Size(75, 32);
            this.btnUnassign.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUnassign.TabIndex = 21;
            this.btnUnassign.Text = "Unassign";
            this.btnUnassign.Click += new System.EventHandler(this.btnUnassign_Click);
            // 
            // btnShow
            // 
            this.btnShow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(13, 91);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 21);
            this.btnShow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShow.TabIndex = 22;
            this.btnShow.Text = "Show";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // ckbOnly
            // 
            // 
            // 
            // 
            this.ckbOnly.BackgroundStyle.Class = "";
            this.ckbOnly.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ckbOnly.Location = new System.Drawing.Point(112, 91);
            this.ckbOnly.Name = "ckbOnly";
            this.ckbOnly.Size = new System.Drawing.Size(176, 21);
            this.ckbOnly.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ckbOnly.TabIndex = 23;
            this.ckbOnly.Text = "Only unassigned employees";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(873, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 21);
            this.textBox1.TabIndex = 24;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(10, 21);
            this.textBox2.TabIndex = 25;
            this.textBox2.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(289, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.cbbPos.Size = new System.Drawing.Size(159, 21);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.cbbDep);
            this.panel3.Controls.Add(this.labelX6);
            this.panel3.Location = new System.Drawing.Point(3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 32);
            this.panel3.TabIndex = 8;
            // 
            // cbbDep
            // 
            this.cbbDep.DisplayMember = "Text";
            this.cbbDep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.ItemHeight = 15;
            this.cbbDep.Location = new System.Drawing.Point(96, 5);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(159, 21);
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
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Location = new System.Drawing.Point(12, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(276, 76);
            this.panel6.TabIndex = 11;
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
            this.dtgvEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgvEmployee.Location = new System.Drawing.Point(12, 118);
            this.dtgvEmployee.Name = "dtgvEmployee";
            this.dtgvEmployee.ReadOnly = true;
            this.dtgvEmployee.Size = new System.Drawing.Size(276, 404);
            this.dtgvEmployee.TabIndex = 26;
            // 
            // fAssignShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 534);
            this.Controls.Add(this.dtgvEmployee);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ckbOnly);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnUnassign);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvShiftEmployee);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAssignShift";
            this.Text = "fAssignShift";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShiftEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgvShiftEmployee;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbShift;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnAssign;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DatePickerFrom;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker DatePickerTo;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnUnassign;
        private DevComponents.DotNetBar.ButtonX btnShow;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbOnly;
        private System.Windows.Forms.TextBox textBox1;
        private DevComponents.Editors.ComboItem comboItem1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbPos;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbDep;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.Panel panel6;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgvEmployee;
    }
}