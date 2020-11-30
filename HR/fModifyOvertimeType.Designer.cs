namespace HR
{
    partial class fModifyOvertimeType
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbValue = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LNames = new DevComponents.DotNetBar.LabelX();
            this.dtgvOTtype = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOTtype)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbValue);
            this.panel4.Controls.Add(this.labelX1);
            this.panel4.Location = new System.Drawing.Point(307, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 32);
            this.panel4.TabIndex = 22;
            // 
            // txbValue
            // 
            // 
            // 
            // 
            this.txbValue.Border.Class = "TextBoxBorder";
            this.txbValue.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbValue.Location = new System.Drawing.Point(122, 5);
            this.txbValue.Name = "txbValue";
            this.txbValue.Size = new System.Drawing.Size(131, 21);
            this.txbValue.TabIndex = 2;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(106, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Overtime Value:";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(316, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Location = new System.Drawing.Point(478, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Location = new System.Drawing.Point(397, 138);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbId);
            this.panel3.Controls.Add(this.labelX3);
            this.panel3.Location = new System.Drawing.Point(307, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 32);
            this.panel3.TabIndex = 23;
            // 
            // txbId
            // 
            // 
            // 
            // 
            this.txbId.Border.Class = "TextBoxBorder";
            this.txbId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbId.Location = new System.Drawing.Point(122, 5);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(131, 21);
            this.txbId.TabIndex = 2;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(3, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(106, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbType);
            this.panel2.Controls.Add(this.LNames);
            this.panel2.Location = new System.Drawing.Point(307, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 32);
            this.panel2.TabIndex = 19;
            // 
            // txbType
            // 
            // 
            // 
            // 
            this.txbType.Border.Class = "TextBoxBorder";
            this.txbType.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbType.Location = new System.Drawing.Point(122, 5);
            this.txbType.Name = "txbType";
            this.txbType.Size = new System.Drawing.Size(131, 21);
            this.txbType.TabIndex = 1;
            // 
            // LNames
            // 
            // 
            // 
            // 
            this.LNames.BackgroundStyle.Class = "";
            this.LNames.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LNames.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNames.Location = new System.Drawing.Point(3, 3);
            this.LNames.Name = "LNames";
            this.LNames.Size = new System.Drawing.Size(115, 23);
            this.LNames.TabIndex = 0;
            this.LNames.Text = "Overtime Type:";
            // 
            // dtgvOTtype
            // 
            this.dtgvOTtype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvOTtype.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvOTtype.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgvOTtype.Location = new System.Drawing.Point(13, 12);
            this.dtgvOTtype.Name = "dtgvOTtype";
            this.dtgvOTtype.Size = new System.Drawing.Size(286, 360);
            this.dtgvOTtype.TabIndex = 16;
            // 
            // fModifyOvertimeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 382);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtgvOTtype);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fModifyOvertimeType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModifyOvertimeType";
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOTtype)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.Controls.TextBoxX txbValue;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.Controls.TextBoxX txbId;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txbType;
        private DevComponents.DotNetBar.LabelX LNames;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgvOTtype;
    }
}