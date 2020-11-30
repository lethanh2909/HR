namespace HR
{
    partial class fManageOvertime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManageOvertime));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbbShiftName = new System.Windows.Forms.ComboBox();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DatePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DatePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnLoad = new DevComponents.DotNetBar.ButtonX();
            this.btnShow = new DevComponents.DotNetBar.ButtonX();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEditType = new DevComponents.DotNetBar.ButtonX();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txbConfirm = new System.Windows.Forms.TextBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txbHour = new System.Windows.Forms.TextBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txbValue = new System.Windows.Forms.TextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.dtgvOvertime = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOvertime)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(15, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 122);
            this.panel3.TabIndex = 20;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbbShiftName);
            this.panel8.Controls.Add(this.labelX5);
            this.panel8.Location = new System.Drawing.Point(3, 80);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(276, 34);
            this.panel8.TabIndex = 37;
            // 
            // cbbShiftName
            // 
            this.cbbShiftName.FormattingEnabled = true;
            this.cbbShiftName.Location = new System.Drawing.Point(112, 5);
            this.cbbShiftName.Name = "cbbShiftName";
            this.cbbShiftName.Size = new System.Drawing.Size(160, 21);
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
            this.labelX5.Size = new System.Drawing.Size(101, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Shift name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DatePickerFrom);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 32);
            this.panel1.TabIndex = 17;
            // 
            // DatePickerFrom
            // 
            this.DatePickerFrom.CustomFormat = "dd/MM/yyyy";
            this.DatePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerFrom.Location = new System.Drawing.Point(112, 5);
            this.DatePickerFrom.Name = "DatePickerFrom";
            this.DatePickerFrom.Size = new System.Drawing.Size(160, 21);
            this.DatePickerFrom.TabIndex = 1;
            this.DatePickerFrom.Value = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
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
            this.labelX1.Size = new System.Drawing.Size(47, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "From:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DatePickerTo);
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Location = new System.Drawing.Point(3, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 32);
            this.panel2.TabIndex = 18;
            // 
            // DatePickerTo
            // 
            this.DatePickerTo.CustomFormat = "dd/MM/yyyy";
            this.DatePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerTo.Location = new System.Drawing.Point(112, 5);
            this.DatePickerTo.Name = "DatePickerTo";
            this.DatePickerTo.Size = new System.Drawing.Size(160, 21);
            this.DatePickerTo.TabIndex = 1;
            this.DatePickerTo.Value = new System.DateTime(2022, 8, 1, 0, 0, 0, 0);
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
            this.labelX2.Size = new System.Drawing.Size(33, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "To:";
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(15, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 31);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLoad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(115, 140);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(83, 31);
            this.btnLoad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLoad.TabIndex = 40;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnShow
            // 
            this.btnShow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.Location = new System.Drawing.Point(219, 140);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(83, 31);
            this.btnShow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShow.TabIndex = 39;
            this.btnShow.Text = "Show";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labelX8);
            this.panel4.Controls.Add(this.btnEditType);
            this.panel4.Controls.Add(this.cbbType);
            this.panel4.Controls.Add(this.labelX7);
            this.panel4.Controls.Add(this.txbConfirm);
            this.panel4.Controls.Add(this.labelX6);
            this.panel4.Controls.Add(this.txbHour);
            this.panel4.Controls.Add(this.labelX4);
            this.panel4.Controls.Add(this.labelX3);
            this.panel4.Controls.Add(this.txbValue);
            this.panel4.Controls.Add(this.txbId);
            this.panel4.Location = new System.Drawing.Point(365, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(315, 122);
            this.panel4.TabIndex = 42;
            // 
            // btnEditType
            // 
            this.btnEditType.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditType.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEditType.Image = ((System.Drawing.Image)(resources.GetObject("btnEditType.Image")));
            this.btnEditType.Location = new System.Drawing.Point(281, 7);
            this.btnEditType.Name = "btnEditType";
            this.btnEditType.Size = new System.Drawing.Size(25, 21);
            this.btnEditType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEditType.TabIndex = 31;
            this.btnEditType.Click += new System.EventHandler(this.btnEditType_Click);
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(139, 7);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(136, 21);
            this.cbbType.TabIndex = 29;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(10, 85);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(120, 23);
            this.labelX7.TabIndex = 28;
            this.labelX7.Text = "Confirmed:";
            // 
            // txbConfirm
            // 
            this.txbConfirm.Location = new System.Drawing.Point(139, 86);
            this.txbConfirm.Name = "txbConfirm";
            this.txbConfirm.Size = new System.Drawing.Size(136, 21);
            this.txbConfirm.TabIndex = 27;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(10, 59);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(120, 23);
            this.labelX6.TabIndex = 26;
            this.labelX6.Text = "Overtime Hours:";
            // 
            // txbHour
            // 
            this.txbHour.Location = new System.Drawing.Point(139, 60);
            this.txbHour.Name = "txbHour";
            this.txbHour.Size = new System.Drawing.Size(136, 21);
            this.txbHour.TabIndex = 25;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(10, 33);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(120, 23);
            this.labelX4.TabIndex = 24;
            this.labelX4.Text = "Overtime Value:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(10, 8);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(110, 23);
            this.labelX3.TabIndex = 22;
            this.labelX3.Text = "Overtime type:";
            // 
            // txbValue
            // 
            this.txbValue.Location = new System.Drawing.Point(139, 34);
            this.txbValue.Name = "txbValue";
            this.txbValue.ReadOnly = true;
            this.txbValue.Size = new System.Drawing.Size(69, 21);
            this.txbValue.TabIndex = 23;
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(106, 86);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(14, 21);
            this.txbId.TabIndex = 30;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(443, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 31);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save changes";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtgvOvertime
            // 
            this.dtgvOvertime.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvOvertime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvOvertime.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvOvertime.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgvOvertime.Location = new System.Drawing.Point(11, 196);
            this.dtgvOvertime.Name = "dtgvOvertime";
            this.dtgvOvertime.Size = new System.Drawing.Size(1093, 326);
            this.dtgvOvertime.TabIndex = 44;
            
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(212, 34);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(31, 21);
            this.labelX8.TabIndex = 32;
            this.labelX8.Text = "%";
            // 
            // fManageOvertime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 534);
            this.Controls.Add(this.dtgvOvertime);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fManageOvertime";
            this.Text = "fManageOvertime";
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOvertime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cbbShiftName;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DatePickerFrom;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DatePickerTo;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnLoad;
        private DevComponents.DotNetBar.ButtonX btnShow;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.TextBox txbValue;
        private System.Windows.Forms.ComboBox cbbType;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.TextBox txbConfirm;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.TextBox txbHour;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgvOvertime;
        private System.Windows.Forms.TextBox txbId;
        private DevComponents.DotNetBar.ButtonX btnEditType;
        private DevComponents.DotNetBar.LabelX labelX8;
    }
}