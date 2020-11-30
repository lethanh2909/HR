namespace HR
{
    partial class fModifyAllFormula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbFormula = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbDes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LNames = new DevComponents.DotNetBar.LabelX();
            this.dtgvAllFormula = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAllFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(383, 69);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(158, 23);
            this.labelX5.TabIndex = 30;
            this.labelX5.Text = "c: Workday in real";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(383, 40);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(158, 23);
            this.labelX4.TabIndex = 29;
            this.labelX4.Text = "b: Workday in a month";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(383, 11);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(106, 23);
            this.labelX2.TabIndex = 28;
            this.labelX2.Text = "a: Salary";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbFormula);
            this.panel4.Controls.Add(this.labelX1);
            this.panel4.Location = new System.Drawing.Point(13, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 32);
            this.panel4.TabIndex = 24;
            // 
            // txbFormula
            // 
            // 
            // 
            // 
            this.txbDes.Border.Class = "TextBoxBorder";
            this.txbDes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbFormula.Location = new System.Drawing.Point(122, 5);
            this.txbFormula.Name = "txbFormula";
            this.txbFormula.Size = new System.Drawing.Size(159, 21);
            this.txbFormula.TabIndex = 2;
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
            this.labelX1.Text = "Formula:";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(13, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Location = new System.Drawing.Point(175, 127);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Location = new System.Drawing.Point(94, 127);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbId);
            this.panel3.Controls.Add(this.labelX3);
            this.panel3.Location = new System.Drawing.Point(13, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 32);
            this.panel3.TabIndex = 25;
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
            this.txbId.Size = new System.Drawing.Size(159, 21);
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
            this.labelX3.Text = "Formula ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbDes);
            this.panel2.Controls.Add(this.LNames);
            this.panel2.Location = new System.Drawing.Point(13, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 32);
            this.panel2.TabIndex = 22;
            // 
            // txbDes
            // 
            // 
            // 
            // 
            this.txbDes.Border.Class = "TextBoxBorder";
            this.txbDes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbDes.Location = new System.Drawing.Point(122, 5);
            this.txbDes.Name = "txbDes";
            this.txbDes.Size = new System.Drawing.Size(159, 21);
            this.txbDes.TabIndex = 1;
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
            this.LNames.Text = "Description:";
            // 
            // dtgvAllFormula
            // 
            this.dtgvAllFormula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvAllFormula.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvAllFormula.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgvAllFormula.Location = new System.Drawing.Point(13, 158);
            this.dtgvAllFormula.Name = "dtgvAllFormula";
            this.dtgvAllFormula.Size = new System.Drawing.Size(541, 214);
            this.dtgvAllFormula.TabIndex = 19;
            // 
            // fModifyAllFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 382);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtgvAllFormula);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fModifyAllFormula";
            this.Text = "Allowances salary";
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAllFormula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.Controls.TextBoxX txbFormula;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.Controls.TextBoxX txbId;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txbDes;
        private DevComponents.DotNetBar.LabelX LNames;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgvAllFormula;
    }
}