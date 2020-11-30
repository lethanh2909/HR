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
    public partial class fManageDepartment : Office2007Form
    {
        BindingSource DepartmentList = new BindingSource();

        public fManageDepartment()
        {
            InitializeComponent();

            dtgvDepartment.DataSource = DepartmentList;
            
            LoadDepartment();
            AddDepartmentBinding();
        }

        private void function(bool b)
        {            
            btnSave.Enabled = btnCancel.Enabled = txbDepartment.Enabled = !b;
            btnAddDepart.Enabled = btnEditDepart.Enabled = btnDeleteDepart.Enabled = b;
        }

        void LoadDepartment()
        {
            function(true);
            DepartmentList.DataSource = DepartmentDAO.Instance.GetListDepartment();
            dtgvDepartment.Columns[1].Visible = false;
            dtgvDepartment.Columns[0].Width = 161;
        }

        void AddDepartmentBinding()
        {
            txbDepartment.DataBindings.Add(new Binding("Text", dtgvDepartment.DataSource, "DepartmentName", true, DataSourceUpdateMode.Never));
        }        


        private bool Add = false, Edit = false;

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

        private void btnAddDepart_Click(object sender, EventArgs e)
        {
            txbDepartment.Clear();
            Add = true;
            Edit = false;
            function(false);
        }

        private void btnEditDepart_Click(object sender, EventArgs e)
        {
            Edit = true;
            Add = false;
            function(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Add == true)
            {
                if (txbDepartment.TextLength == 0)
                {
                    MessageBox.Show("Enter the department name", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        string name = txbDepartment.Text;
                        DepartmentDAO.Instance.InsertDepartment(name);
                        MessageBox.Show("Add successfully");
                        LoadDepartment();
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
                if (txbDepartment.TextLength == 0)
                {
                    MessageBox.Show("Enter the department name", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        string name = txbDepartment.Text;
                        int id = Convert.ToInt32(dtgvDepartment.Rows[dtgvDepartment.CurrentRow.Index].Cells[1].Value);

                        DepartmentDAO.Instance.UpdateDepartment(name, id);
                        MessageBox.Show("Edit successfully");
                        LoadDepartment();
                        function(true);
                    }
                    catch
                    {
                        MessageBox.Show("Edit failed");
                    }
                }
            }
        }         

        private void btnDeleteDepart_Click(object sender, EventArgs e)
        {        
            
            int id = Convert.ToInt32(dtgvDepartment.Rows[dtgvDepartment.CurrentRow.Index].Cells[1].Value);

            if (PositionDAO.Instance.CheckPositionyByDeID(id) == null)
            {
                DepartmentDAO.Instance.DeleteDepartment(id);
                MessageBox.Show("Delete successfully");
                LoadDepartment();
                 
            }
            else
            {                
                MessageBox.Show("Delete failed");
            }
        }

        
    }
}
