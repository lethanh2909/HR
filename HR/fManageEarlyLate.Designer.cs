namespace HR
{
    partial class fManageEarlyLate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManageEarlyLate));
            this.dtgvLateEarly = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DatePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DatePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbbShiftName = new System.Windows.Forms.ComboBox();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txbConfirmLate = new System.Windows.Forms.TextBox();
            this.txbValueLate = new System.Windows.Forms.TextBox();
            this.ckbLateIn = new System.Windows.Forms.CheckBox();
            this.ckbEarlyOut = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txbConfirmEarly = new System.Windows.Forms.TextBox();
            this.txbValueEarly = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbLast = new DevComponents.DotNetBar.LabelX();
            this.lbId = new DevComponents.DotNetBar.LabelX();
            this.labelName = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.lbFisrt = new DevComponents.DotNetBar.LabelX();
            this.txbId = new System.Windows.Forms.TextBox();
            this.btnShow = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.textBoxItem1 = new DevComponents.DotNetBar.TextBoxItem();
            this.btnLoad = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLateEarly)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvLateEarly
            // 
            this.dtgvLateEarly.AllowUserToAddRows = false;
            this.dtgvLateEarly.AllowUserToDeleteRows = false;
            this.dtgvLateEarly.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvLateEarly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvLateEarly.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvLateEarly.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgvLateEarly.Location = new System.Drawing.Point(12, 182);
            this.dtgvLateEarly.Name = "dtgvLateEarly";
            this.dtgvLateEarly.ReadOnly = true;
            this.dtgvLateEarly.Size = new System.Drawing.Size(1090, 340);
            this.dtgvLateEarly.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DatePickerFrom);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 32);
            this.panel1.TabIndex = 17;
            // 
            // DatePickerFrom
            // 
            this.DatePickerFrom.CustomFormat = "dd/MM/yyyy";
            this.DatePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerFrom.Location = new System.Drawing.Point(96, 5);
            this.DatePickerFrom.Name = "DatePickerFrom";
            this.DatePickerFrom.Size = new System.Drawing.Size(138, 21);
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
            this.panel2.Location = new System.Drawing.Point(3, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 32);
            this.panel2.TabIndex = 18;
            // 
            // DatePickerTo
            // 
            this.DatePickerTo.CustomFormat = "dd/MM/yyyy";
            this.DatePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerTo.Location = new System.Drawing.Point(96, 5);
            this.DatePickerTo.Name = "DatePickerTo";
            this.DatePickerTo.Size = new System.Drawing.Size(138, 21);
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
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(13, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 127);
            this.panel3.TabIndex = 19;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbbShiftName);
            this.panel8.Controls.Add(this.labelX5);
            this.panel8.Location = new System.Drawing.Point(3, 80);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(237, 34);
            this.panel8.TabIndex = 37;
            // 
            // cbbShiftName
            // 
            this.cbbShiftName.FormattingEnabled = true;
            this.cbbShiftName.Location = new System.Drawing.Point(96, 3);
            this.cbbShiftName.Name = "cbbShiftName";
            this.cbbShiftName.Size = new System.Drawing.Size(138, 21);
            this.cbbShiftName.TabIndex = 1;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(3, 3);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(87, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Shift name:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labelX4);
            this.panel4.Controls.Add(this.labelX3);
            this.panel4.Controls.Add(this.txbConfirmLate);
            this.panel4.Controls.Add(this.txbValueLate);
            this.panel4.Controls.Add(this.ckbLateIn);
            this.panel4.Location = new System.Drawing.Point(8, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 86);
            this.panel4.TabIndex = 20;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(13, 53);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(94, 23);
            this.labelX4.TabIndex = 24;
            this.labelX4.Text = "Confirm Value:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(13, 28);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(59, 23);
            this.labelX3.TabIndex = 22;
            this.labelX3.Text = "Value:";
            // 
            // txbConfirmLate
            // 
            this.txbConfirmLate.Location = new System.Drawing.Point(113, 54);
            this.txbConfirmLate.Name = "txbConfirmLate";
            this.txbConfirmLate.Size = new System.Drawing.Size(65, 21);
            this.txbConfirmLate.TabIndex = 23;
            // 
            // txbValueLate
            // 
            this.txbValueLate.Location = new System.Drawing.Point(113, 29);
            this.txbValueLate.Name = "txbValueLate";
            this.txbValueLate.ReadOnly = true;
            this.txbValueLate.Size = new System.Drawing.Size(65, 21);
            this.txbValueLate.TabIndex = 1;
            // 
            // ckbLateIn
            // 
            this.ckbLateIn.AutoSize = true;
            this.ckbLateIn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLateIn.Location = new System.Drawing.Point(54, 5);
            this.ckbLateIn.Name = "ckbLateIn";
            this.ckbLateIn.Size = new System.Drawing.Size(72, 17);
            this.ckbLateIn.TabIndex = 0;
            this.ckbLateIn.Text = "Late In";
            this.ckbLateIn.UseVisualStyleBackColor = true;
            this.ckbLateIn.CheckedChanged += new System.EventHandler(this.ckbLateIn_CheckedChanged);
            // 
            // ckbEarlyOut
            // 
            this.ckbEarlyOut.AutoSize = true;
            this.ckbEarlyOut.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEarlyOut.Location = new System.Drawing.Point(53, 5);
            this.ckbEarlyOut.Name = "ckbEarlyOut";
            this.ckbEarlyOut.Size = new System.Drawing.Size(86, 17);
            this.ckbEarlyOut.TabIndex = 1;
            this.ckbEarlyOut.Text = "Early Out";
            this.ckbEarlyOut.UseVisualStyleBackColor = true;
            this.ckbEarlyOut.CheckedChanged += new System.EventHandler(this.ckbEarlyOut_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.labelX6);
            this.panel5.Controls.Add(this.ckbEarlyOut);
            this.panel5.Controls.Add(this.labelX7);
            this.panel5.Controls.Add(this.txbConfirmEarly);
            this.panel5.Controls.Add(this.txbValueEarly);
            this.panel5.Location = new System.Drawing.Point(199, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(192, 86);
            this.panel5.TabIndex = 21;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(14, 54);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(94, 23);
            this.labelX6.TabIndex = 24;
            this.labelX6.Text = "Confirm Value:";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(14, 28);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(59, 23);
            this.labelX7.TabIndex = 22;
            this.labelX7.Text = "Value:";
            // 
            // txbConfirmEarly
            // 
            this.txbConfirmEarly.Location = new System.Drawing.Point(114, 55);
            this.txbConfirmEarly.Name = "txbConfirmEarly";
            this.txbConfirmEarly.Size = new System.Drawing.Size(65, 21);
            this.txbConfirmEarly.TabIndex = 23;
            // 
            // txbValueEarly
            // 
            this.txbValueEarly.Location = new System.Drawing.Point(114, 29);
            this.txbValueEarly.Name = "txbValueEarly";
            this.txbValueEarly.ReadOnly = true;
            this.txbValueEarly.Size = new System.Drawing.Size(65, 21);
            this.txbValueEarly.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lbLast);
            this.panel6.Controls.Add(this.lbId);
            this.panel6.Controls.Add(this.labelName);
            this.panel6.Controls.Add(this.labelX8);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.lbFisrt);
            this.panel6.Controls.Add(this.txbId);
            this.panel6.Location = new System.Drawing.Point(275, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(399, 127);
            this.panel6.TabIndex = 22;
            // 
            // lbLast
            // 
            // 
            // 
            // 
            this.lbLast.BackgroundStyle.Class = "";
            this.lbLast.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbLast.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLast.Location = new System.Drawing.Point(314, 0);
            this.lbLast.Name = "lbLast";
            this.lbLast.Size = new System.Drawing.Size(43, 23);
            this.lbLast.TabIndex = 27;
            this.lbLast.Text = "...";
            // 
            // lbId
            // 
            // 
            // 
            // 
            this.lbId.BackgroundStyle.Class = "";
            this.lbId.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(101, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(49, 23);
            this.lbId.TabIndex = 25;
            this.lbId.Text = "...";
            // 
            // labelName
            // 
            // 
            // 
            // 
            this.labelName.BackgroundStyle.Class = "";
            this.labelName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(156, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(108, 23);
            this.labelName.TabIndex = 24;
            this.labelName.Text = "Employee name:";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(8, 0);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(91, 23);
            this.labelX8.TabIndex = 23;
            this.labelX8.Text = "Employee ID:";
            // 
            // lbFisrt
            // 
            // 
            // 
            // 
            this.lbFisrt.BackgroundStyle.Class = "";
            this.lbFisrt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbFisrt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFisrt.Location = new System.Drawing.Point(265, 0);
            this.lbFisrt.Name = "lbFisrt";
            this.lbFisrt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbFisrt.Size = new System.Drawing.Size(43, 23);
            this.lbFisrt.TabIndex = 26;
            this.lbFisrt.Text = "...";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(280, 2);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(10, 21);
            this.txbId.TabIndex = 38;
            // 
            // btnShow
            // 
            this.btnShow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.Location = new System.Drawing.Point(188, 145);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(71, 31);
            this.btnShow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShow.TabIndex = 23;
            this.btnShow.Text = "Show";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(418, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 31);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save changes";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBoxItem1
            // 
            this.textBoxItem1.GlobalItem = false;
            this.textBoxItem1.Name = "textBoxItem1";
            this.textBoxItem1.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // btnLoad
            // 
            this.btnLoad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLoad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(99, 145);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(71, 31);
            this.btnLoad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLoad.TabIndex = 37;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(13, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 31);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // fManageEarlyLate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 534);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dtgvLateEarly);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fManageEarlyLate";
            this.Text = "fManageInOut";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLateEarly)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgvLateEarly;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DatePickerFrom;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DatePickerTo;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox ckbEarlyOut;
        private System.Windows.Forms.CheckBox ckbLateIn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cbbShiftName;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.TextBox txbConfirmLate;
        private System.Windows.Forms.TextBox txbValueLate;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.TextBox txbConfirmEarly;
        private System.Windows.Forms.TextBox txbValueEarly;
        private System.Windows.Forms.Panel panel6;
        private DevComponents.DotNetBar.LabelX lbFisrt;
        private DevComponents.DotNetBar.LabelX lbId;
        private DevComponents.DotNetBar.LabelX labelName;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.ButtonX btnShow;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.TextBoxItem textBoxItem1;
        private DevComponents.DotNetBar.LabelX lbLast;
        private DevComponents.DotNetBar.ButtonX btnLoad;
        private System.Windows.Forms.TextBox txbId;
        private DevComponents.DotNetBar.ButtonX btnDelete;
    }
}