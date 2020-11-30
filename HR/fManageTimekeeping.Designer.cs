namespace HR
{
    partial class fManageTimekeeping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManageTimekeeping));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DatePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DatePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnShow = new DevComponents.DotNetBar.ButtonX();
            this.rbNoInOut = new System.Windows.Forms.RadioButton();
            this.rbNoIn = new System.Windows.Forms.RadioButton();
            this.rbNoOut = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbAbsent = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbAbsence = new System.Windows.Forms.ComboBox();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbClockOut = new System.Windows.Forms.TextBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbClockIn = new System.Windows.Forms.TextBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dtgvTimekeeping = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimekeeping)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DatePickerFrom);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 32);
            this.panel1.TabIndex = 16;
            // 
            // DatePickerFrom
            // 
            this.DatePickerFrom.CustomFormat = "dd/MM/yyyy";
            this.DatePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerFrom.Location = new System.Drawing.Point(47, 3);
            this.DatePickerFrom.Name = "DatePickerFrom";
            this.DatePickerFrom.Size = new System.Drawing.Size(125, 21);
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
            this.panel2.Location = new System.Drawing.Point(188, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 32);
            this.panel2.TabIndex = 17;
            // 
            // DatePickerTo
            // 
            this.DatePickerTo.CustomFormat = "dd/MM/yyyy";
            this.DatePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerTo.Location = new System.Drawing.Point(28, 3);
            this.DatePickerTo.Name = "DatePickerTo";
            this.DatePickerTo.Size = new System.Drawing.Size(125, 21);
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
            // btnShow
            // 
            this.btnShow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.Location = new System.Drawing.Point(142, 104);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(77, 31);
            this.btnShow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShow.TabIndex = 19;
            this.btnShow.Text = "Show";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // rbNoInOut
            // 
            this.rbNoInOut.AutoSize = true;
            this.rbNoInOut.BackColor = System.Drawing.Color.Thistle;
            this.rbNoInOut.Location = new System.Drawing.Point(188, 43);
            this.rbNoInOut.Name = "rbNoInOut";
            this.rbNoInOut.Size = new System.Drawing.Size(134, 17);
            this.rbNoInOut.TabIndex = 26;
            this.rbNoInOut.Text = "No clock in and out";
            this.rbNoInOut.UseVisualStyleBackColor = false;
            // 
            // rbNoIn
            // 
            this.rbNoIn.AutoSize = true;
            this.rbNoIn.BackColor = System.Drawing.Color.Khaki;
            this.rbNoIn.Location = new System.Drawing.Point(77, 43);
            this.rbNoIn.Name = "rbNoIn";
            this.rbNoIn.Size = new System.Drawing.Size(87, 17);
            this.rbNoIn.TabIndex = 27;
            this.rbNoIn.Text = "No clock in";
            this.rbNoIn.UseVisualStyleBackColor = false;
            // 
            // rbNoOut
            // 
            this.rbNoOut.AutoSize = true;
            this.rbNoOut.BackColor = System.Drawing.Color.PeachPuff;
            this.rbNoOut.Location = new System.Drawing.Point(77, 66);
            this.rbNoOut.Name = "rbNoOut";
            this.rbNoOut.Size = new System.Drawing.Size(95, 17);
            this.rbNoOut.TabIndex = 28;
            this.rbNoOut.Text = "No clock out";
            this.rbNoOut.UseVisualStyleBackColor = false;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(10, 43);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(39, 17);
            this.rbAll.TabIndex = 29;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbAbsent
            // 
            this.rbAbsent.AutoSize = true;
            this.rbAbsent.BackColor = System.Drawing.Color.Salmon;
            this.rbAbsent.Location = new System.Drawing.Point(188, 66);
            this.rbAbsent.Name = "rbAbsent";
            this.rbAbsent.Size = new System.Drawing.Size(64, 17);
            this.rbAbsent.TabIndex = 30;
            this.rbAbsent.Text = "Absent";
            this.rbAbsent.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonX1);
            this.panel3.Controls.Add(this.rbNoInOut);
            this.panel3.Controls.Add(this.rbNoIn);
            this.panel3.Controls.Add(this.btnShow);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.rbNoOut);
            this.panel3.Controls.Add(this.rbAbsent);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.rbAll);
            this.panel3.Location = new System.Drawing.Point(13, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 143);
            this.panel3.TabIndex = 31;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(393, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 143);
            this.panel5.TabIndex = 33;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(68, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 31);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save changes";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbAbsence);
            this.panel8.Controls.Add(this.labelX5);
            this.panel8.Location = new System.Drawing.Point(3, 67);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(228, 30);
            this.panel8.TabIndex = 36;
            // 
            // txbAbsence
            // 
            this.txbAbsence.FormattingEnabled = true;
            this.txbAbsence.Location = new System.Drawing.Point(106, 5);
            this.txbAbsence.Name = "txbAbsence";
            this.txbAbsence.Size = new System.Drawing.Size(119, 21);
            this.txbAbsence.TabIndex = 1;
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
            this.labelX5.Size = new System.Drawing.Size(96, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Absence type:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbClockOut);
            this.panel7.Controls.Add(this.labelX4);
            this.panel7.Location = new System.Drawing.Point(3, 35);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(228, 30);
            this.panel7.TabIndex = 35;
            // 
            // txbClockOut
            // 
            this.txbClockOut.Location = new System.Drawing.Point(106, 5);
            this.txbClockOut.Name = "txbClockOut";
            this.txbClockOut.Size = new System.Drawing.Size(119, 21);
            this.txbClockOut.TabIndex = 1;
            this.txbClockOut.Validating += new System.ComponentModel.CancelEventHandler(this.txbClockOut_Validating);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(3, 3);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(92, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Clock Out:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbClockIn);
            this.panel6.Controls.Add(this.labelX3);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(228, 30);
            this.panel6.TabIndex = 34;
            // 
            // txbClockIn
            // 
            this.txbClockIn.Location = new System.Drawing.Point(106, 4);
            this.txbClockIn.Name = "txbClockIn";
            this.txbClockIn.Size = new System.Drawing.Size(119, 21);
            this.txbClockIn.TabIndex = 1;
            this.txbClockIn.Validating += new System.ComponentModel.CancelEventHandler(this.txbClockIn_Validating);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(3, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(92, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Clock In:";
            // 
            // dtgvTimekeeping
            // 
            this.dtgvTimekeeping.AllowUserToAddRows = false;
            this.dtgvTimekeeping.AllowUserToDeleteRows = false;
            this.dtgvTimekeeping.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvTimekeeping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTimekeeping.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTimekeeping.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgvTimekeeping.Location = new System.Drawing.Point(13, 161);
            this.dtgvTimekeeping.Name = "dtgvTimekeeping";
            this.dtgvTimekeeping.ReadOnly = true;
            this.dtgvTimekeeping.Size = new System.Drawing.Size(1085, 361);
            this.dtgvTimekeeping.TabIndex = 0;
            this.dtgvTimekeeping.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgvTimekeeping_CellPainting);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(10, 104);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(77, 31);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 31;
            this.buttonX1.Text = "Import";
            // 
            // fManageTimekeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dtgvTimekeeping);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fManageTimekeeping";
            this.Text = "fManageTimekeeping";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimekeeping)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DatePickerFrom;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DatePickerTo;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnShow;
        private System.Windows.Forms.RadioButton rbNoInOut;
        private System.Windows.Forms.RadioButton rbNoIn;
        private System.Windows.Forms.RadioButton rbNoOut;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbAbsent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox txbAbsence;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.Panel panel7;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.Panel panel6;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.TextBox txbClockOut;
        private System.Windows.Forms.TextBox txbClockIn;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgvTimekeeping;
        private System.Windows.Forms.Button button1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}