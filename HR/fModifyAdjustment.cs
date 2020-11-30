using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using HR.DAO;

namespace HR
{
    public partial class fModifyAdjustment : Office2007Form
    {
        BindingSource Adjustment = new BindingSource();
        public fModifyAdjustment()
        {
            InitializeComponent();
            loadAdjustment();
            AddAdjustmentBinding();
            function(true);
        }

        void loadAdjustment()
        {
            dtgvAdjustment.DataSource = Adjustment;
            Adjustment.DataSource = AdjustmentDAO.Instance.GetListAdjustment();
            // spc 43
            dtgvAdjustment.Columns[0].Width = 120;
            dtgvAdjustment.Columns[1].Width = 120;
            dtgvAdjustment.Columns[2].Width = 258;
            dtgvAdjustment.Columns[3].Visible = false;            
        }

        void AddAdjustmentBinding()
        {
            txbAdId.DataBindings.Add(new Binding("Text", dtgvAdjustment.DataSource, "AdjustmentId", true, DataSourceUpdateMode.Never));
            txbAdName.DataBindings.Add(new Binding("Text", dtgvAdjustment.DataSource, "AdjustmentName", true, DataSourceUpdateMode.Never));
            cbbAdType.DataBindings.Add(new Binding("Text", dtgvAdjustment.DataSource, "AdjustmentType", true, DataSourceUpdateMode.Never));            
        }

        private void function(bool b)
        {
            btnSave.Enabled = btnCancel.Enabled = txbAdId.Enabled = txbAdName.Enabled = cbbAdType.Enabled = !b;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = b;
        }

        private bool Add = false, Edit = false;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txbAdId.Clear();
            txbAdName.Clear();
            Add = true;
            Edit = false;
            function(false);                          
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Add = false;
            Edit = true;
            function(false);            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Add == true)
            {
                if (txbAdName.TextLength == 0)
                {
                    MessageBox.Show("Enter the Adjustment name", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        int id = Convert.ToInt32(txbAdId.Text);
                        string name = txbAdName.Text;
                        string type = cbbAdType.GetItemText(cbbAdType.SelectedItem);
                        AdjustmentDAO.Instance.InsertAdjustment(id, name, type);
                        MessageBox.Show("Add successfully");
                        loadAdjustment();
                        function(true);
                    }
                    catch
                    {
                        MessageBox.Show("Add failed");
                    }
                }
            }
            else if (Edit == true)
            {
                if (txbAdName.TextLength == 0)
                {
                    MessageBox.Show("Enter the Adjustment name", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        int id = Convert.ToInt32(txbAdId.Text);
                        string name = txbAdName.Text;
                        string type = cbbAdType.GetItemText(cbbAdType.SelectedItem);
                        AdjustmentDAO.Instance.UpdateAdjustment(id, name, type);
                        MessageBox.Show("Edit successfully", "Message", MessageBoxButtons.OK);
                        loadAdjustment();
                        function(true);
                    }
                    catch
                    {
                        MessageBox.Show("Edit failed");
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Add == true)
            {
                Add = false;
                function(true);
            }
            else if (Edit == true)
            {
                Edit = false;
                function(true);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo))
            {
                if (txbAdId.TextLength == 0)
                {
                    MessageBox.Show("Select item to delete", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    int Id = Convert.ToInt32(txbAdId.Text);
                    AdjustmentDAO.Instance.DeleteAdjustment(Id);
                    loadAdjustment();
                }
            }
        }
    }
}
