namespace HR
{
    partial class fModifyAdjustment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvAdjustment = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbAdName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LNames = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbAdType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Decreasement = new DevComponents.Editors.ComboItem();
            this.Increasement = new DevComponents.Editors.ComboItem();
            this.LTypes = new DevComponents.DotNetBar.LabelX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbAdId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAdjustment)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvAdjustment
            // 
            this.dtgvAdjustment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvAdjustment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvAdjustment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtgvAdjustment.Location = new System.Drawing.Point(13, 151);
            this.dtgvAdjustment.Name = "dtgvAdjustment";
            this.dtgvAdjustment.Size = new System.Drawing.Size(541, 186);
            this.dtgvAdjustment.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbAdName);
            this.panel2.Controls.Add(this.LNames);
            this.panel2.Location = new System.Drawing.Point(13, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 32);
            this.panel2.TabIndex = 2;
            // 
            // txbAdName
            // 
            // 
            // 
            // 
            this.txbAdName.Border.Class = "TextBoxBorder";
            this.txbAdName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbAdName.Location = new System.Drawing.Point(122, 5);
            this.txbAdName.Name = "txbAdName";
            this.txbAdName.Size = new System.Drawing.Size(159, 21);
            this.txbAdName.TabIndex = 1;
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
            this.LNames.Text = "Adjustment name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbAdType);
            this.panel1.Controls.Add(this.LTypes);
            this.panel1.Location = new System.Drawing.Point(13, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 32);
            this.panel1.TabIndex = 3;
            // 
            // cbbAdType
            // 
            this.cbbAdType.DisplayMember = "Text";
            this.cbbAdType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbAdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAdType.FormattingEnabled = true;
            this.cbbAdType.ItemHeight = 15;
            this.cbbAdType.Items.AddRange(new object[] {
            this.Decreasement,
            this.Increasement});
            this.cbbAdType.Location = new System.Drawing.Point(122, 5);
            this.cbbAdType.Name = "cbbAdType";
            this.cbbAdType.Size = new System.Drawing.Size(159, 21);
            this.cbbAdType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbAdType.TabIndex = 1;
            // 
            // Decreasement
            // 
            this.Decreasement.Text = "Decreasement";
            // 
            // Increasement
            // 
            this.Increasement.Text = "Increasement";
            // 
            // LTypes
            // 
            // 
            // 
            // 
            this.LTypes.BackgroundStyle.Class = "";
            this.LTypes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LTypes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTypes.Location = new System.Drawing.Point(3, 3);
            this.LTypes.Name = "LTypes";
            this.LTypes.Size = new System.Drawing.Size(106, 23);
            this.LTypes.TabIndex = 0;
            this.LTypes.Text = "Adjustment type:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbAdId);
            this.panel3.Controls.Add(this.labelX3);
            this.panel3.Location = new System.Drawing.Point(13, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 32);
            this.panel3.TabIndex = 4;
            // 
            // txbAdId
            // 
            // 
            // 
            // 
            this.txbAdId.Border.Class = "TextBoxBorder";
            this.txbAdId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbAdId.Location = new System.Drawing.Point(122, 5);
            this.txbAdId.Name = "txbAdId";
            this.txbAdId.Size = new System.Drawing.Size(159, 21);
            this.txbAdId.TabIndex = 2;
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
            this.labelX3.Text = "Adjustment ID:";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(16, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Location = new System.Drawing.Point(219, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Location = new System.Drawing.Point(117, 120);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(476, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(395, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // fModifyAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 349);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtgvAdjustment);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fModifyAdjustment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Adjustment";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAdjustment)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgvAdjustment;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txbAdName;
        private DevComponents.DotNetBar.LabelX LNames;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbAdType;
        private DevComponents.DotNetBar.LabelX LTypes;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.Controls.TextBoxX txbAdId;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.Editors.ComboItem Decreasement;
        private DevComponents.Editors.ComboItem Increasement;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}