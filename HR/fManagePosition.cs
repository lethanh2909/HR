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
using HR.DTO;

namespace HR
{
    public partial class fManagePosition : Office2007Form
    {
        BindingSource PositionList = new BindingSource();

        public fManagePosition()
        {
            InitializeComponent();
            
            dtgvPosition.DataSource = PositionList;

            LoadDepartmentIntoCb();
            AddPositionBinding();
        }

        void LoadDepartmentIntoCb()
        {
            List<Department> listDepartment = DepartmentDAO.Instance.GetListDepartment();
            cbDepartment.DataSource = listDepartment;
            cbDepartment.DisplayMember = "DepartmentName";
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Department selected = cb.SelectedItem as Department;
            id = selected.ID;

            LoadPositionbyID(id);
            
        }

        void LoadPositionbyID(int id)
        {
            function(true);
            PositionList.DataSource = PositionDAO.Instance.GetListPositionbyDepId(id);
            dtgvPosition.Columns[1].Visible = false;
            dtgvPosition.Columns[2].Visible = false;
            dtgvPosition.Columns[0].Width = 169;
        }

        void AddPositionBinding()
        {
            txbPosition.DataBindings.Add(new Binding("Text", dtgvPosition.DataSource, "PositionName", true, DataSourceUpdateMode.Never));
        }

        

        private void function(bool b)
        {
            btnSave.Enabled = btnCancel.Enabled = txbPosition.Enabled = !b;
            btnAddPos.Enabled = btnEditPos.Enabled = btnDeletePos.Enabled = b;
        }

        private bool Add = false, Edit = false;

        private void btnAddPos_Click(object sender, EventArgs e)
        {            
            txbPosition.Clear();
            Add = true;
            Edit = false;
            function(false);
        }

        private void btnEditPos_Click(object sender, EventArgs e)
        {
            Add = false;
            Edit = true;
            function(false);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Add == true)
            {
                if (txbPosition.TextLength == 0)
                {
                    MessageBox.Show("Enter the Position name", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        string name = txbPosition.Text;
                        int deid = (cbDepartment.SelectedItem as Department).ID;
                        PositionDAO.Instance.InsertPosition(name, deid);
                        MessageBox.Show("Add successfully");
                        LoadPositionbyID(deid);
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
                if (txbPosition.TextLength == 0)
                {
                    MessageBox.Show("Enter the Position name", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        string name = txbPosition.Text;
                        int id = Convert.ToInt32(dtgvPosition.Rows[dtgvPosition.CurrentRow.Index].Cells[1].Value);
                        int deid = (cbDepartment.SelectedItem as Department).ID;

                        PositionDAO.Instance.UpdatePosition(name, id);
                        MessageBox.Show("Edit successfully");
                        LoadPositionbyID(deid);
                        function(true);
                    }
                    catch
                    {
                        MessageBox.Show("Edit failed");
                    }
                }
            }
        }

        private void btnDeletePos_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgvPosition.Rows[dtgvPosition.CurrentRow.Index].Cells[1].Value);
            int deid = (cbDepartment.SelectedItem as Department).ID;

            if (EmployeeDAO.Instance.CheckEmployeeByPosID(id) == null)
            {
                PositionDAO.Instance.DeletePosition(id);
                MessageBox.Show("Delete successfully");
                LoadPositionbyID(deid);

            }
            else
            {
                MessageBox.Show("Delete failed");
            }
        }
    }
    
}
