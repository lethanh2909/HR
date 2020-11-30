using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using HR.DTO;
using HR.DAO;

namespace HR
{
    public partial class fAdjustSalary : Office2007Form
    {
        BindingSource AdjustSalaryInfo = new BindingSource();

        public fAdjustSalary()
        {
            InitializeComponent();
            function(true);
            SetCbbYear();
            LoadAdjustmentIntoCb();
            loadSalaryAdjustment();
            LoadDepartmentIntoCb();
            checkBox1.Checked = false;
            panel5.Enabled = false;
            panel6.Enabled = false;
            radAmount.Checked = true;
            txbAmount.ReadOnly = false;
            txbPercent.ReadOnly = true;            
            txbPercent.Text = "0";            
            AddAdjustSalaryBinding();       
            
        }

        void SetCbbYear()
        {         
            cbbYear.DataSource = Enumerable.Range(1983, DateTime.Now.Year - 1983 + 1).ToList();
            cbbYear.SelectedItem = DateTime.Now.Year;
            cbbMonth.SelectedItem = 1;           
        }

        void LoadAdjustmentIntoCb()
        {
            List<Adjustment> listDepartment = AdjustmentDAO.Instance.GetListAdjustment();
            cbbType.DataSource = listDepartment;
            cbbType.DisplayMember = "AdjustmentName";            
        }

        void loadSalaryAdjustment()
        {
            dtgvSalaryAdjust.DataSource = AdjustSalaryInfo;
            AdjustSalaryInfo.DataSource = SalaryAdjustmentDAO.Instance.GetListSalaryAdjustment();

            dtgvSalaryAdjust.Columns[0].Width = 120;
            dtgvSalaryAdjust.Columns[1].Width = 130;
            dtgvSalaryAdjust.Columns[2].Width = 130;
            dtgvSalaryAdjust.Columns[3].Visible = false;
            dtgvSalaryAdjust.Columns[4].Visible = false;
            dtgvSalaryAdjust.Columns[5].Width = 120;
            dtgvSalaryAdjust.Columns[6].Width = 100;
            dtgvSalaryAdjust.Columns[7].Width = 100;
            dtgvSalaryAdjust.Columns[8].Width = 342;    
                   
        }
        

        void AddAdjustSalaryBinding()
        {
            txbID.DataBindings.Add(new Binding("Text", dtgvSalaryAdjust.DataSource, "Employee Id", true, DataSourceUpdateMode.Never));
            txbName.DataBindings.Add(new Binding("Text", dtgvSalaryAdjust.DataSource, "Employee Name", true, DataSourceUpdateMode.Never));
            cbbType.DataBindings.Add(new Binding("Text", dtgvSalaryAdjust.DataSource, "Adjustment Type", true, DataSourceUpdateMode.Never));
            txbAmount.DataBindings.Add(new Binding("Text", dtgvSalaryAdjust.DataSource, "Amount", true, DataSourceUpdateMode.Never));
            txbPercent.DataBindings.Add(new Binding("Text", dtgvSalaryAdjust.DataSource, "Salary percentage", true, DataSourceUpdateMode.Never));
            cbbMonth.DataBindings.Add(new Binding("Text", dtgvSalaryAdjust.DataSource, "ApplytoMonth", true, DataSourceUpdateMode.Never));
            cbbYear.DataBindings.Add(new Binding("Text", dtgvSalaryAdjust.DataSource, "AdjustmentYear", true, DataSourceUpdateMode.Never));
            txbDes.DataBindings.Add(new Binding("Text", dtgvSalaryAdjust.DataSource, "Description", true, DataSourceUpdateMode.Never));
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            fModifyAdjustment f = new fModifyAdjustment();
            f.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id;
            id = txbID.Text;
            DataTable employee = EmployeeDAO.Instance.GetTableEmployeeName(id);
            foreach (DataRow dataRow in employee.Rows)
            {
                string name = Convert.ToString(dataRow["name"]);
                txbName.Text = name;
            }
        }

        private void radAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (radPercent.Checked == true)
            {
                txbAmount.ReadOnly = true;                
                txbPercent.ReadOnly = false;
                txbAmount.Text = "0";
            }
        }

        private void radPercent_CheckedChanged(object sender, EventArgs e)
        {
           if (radAmount.Checked == true)
           {
                txbAmount.ReadOnly = false;
                txbPercent.ReadOnly = true;
                txbPercent.Text = "0";
           }
        }

        void LoadDepartmentIntoCb()
        {           
            List<Department> listDepartment = DepartmentDAO.Instance.GetListDepartment();
            cbbDep.DataSource = listDepartment;
            cbbDep.DisplayMember = "DepartmentName";
            cbbDep.Text = "None";
        }

        private void cbbDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            Department selected = cb.SelectedItem as Department;
            id = selected.ID;

            LoadPositionIntoCb(id);
        }

        void LoadPositionIntoCb(int id)
        {            
            List<Position> listPosition = PositionDAO.Instance.GetListPositionbyDepId(id);
            cbbPos.DataSource = listPosition;
            cbbPos.DisplayMember = "PositionName";
            
            if (listPosition == null)
            {
                cbbPos.Items.Clear();
            }
            cbbPos.Text = "None";
        }

        private void function(bool b)
        {
            btnApply.Enabled = btnCancel.Enabled = txbDes.Enabled = cbbType.Enabled = cbbMonth.Enabled  = cbbYear.Enabled = !b;
            btnNew.Enabled = btnEdit.Enabled = btnDelete.Enabled = b;

            
        }

        private bool Add = false, Edit = false;

        void ApplytoPosition()
        {
            try
            {
                int id = (cbbPos.SelectedItem as Position).ID;

                List<Employee> list = EmployeeDAO.Instance.GetListEmployeeByPosID(id);
                foreach (Employee name in list)
                {
                    string empid = name.EmpId;
                    string empname = name.FirstName + " " + name.LastName;
                    string type = (cbbType.SelectedItem as Adjustment).AdjustmentName;
                    int amount = Convert.ToInt32(txbAmount.Text);
                    int percent = Convert.ToInt32(txbPercent.Text);
                    int month = Convert.ToInt32(cbbMonth.Text);
                    int year = Convert.ToInt32(cbbYear.Text);
                    string description = txbDes.Text;

                    SalaryAdjustmentDAO.Instance.InsertSalaryAdjustment(empid, empname, type, amount, percent, month, year, description);

                }
                MessageBox.Show("Apply successfully", "Message", MessageBoxButtons.OK);
                function(true);
                loadSalaryAdjustment();
            }
            catch
            {
                MessageBox.Show("Apply failed", "Message", MessageBoxButtons.OK);
            }
        }
        

        private void btnApply_Click(object sender, EventArgs e)
        {
            
            if (Add == true)
            {
                if (cbbPos.Text == "none" || cbbPos.Text == "")
                {
                    if (txbID.TextLength == 0)
                    {
                        MessageBox.Show("Select the ID", "Message", MessageBoxButtons.OK);
                    }
                    else
                    {
                        try
                        {
                            string id = txbID.Text;
                            string name = txbName.Text;
                            string type = (cbbType.SelectedItem as Adjustment).AdjustmentName;
                            int amount = Convert.ToInt32(txbAmount.Text);
                            int percent = Convert.ToInt32(txbPercent.Text);
                            int month = Convert.ToInt32(cbbMonth.Text);
                            int year = Convert.ToInt32(cbbYear.Text);
                            string description = txbDes.Text;

                            SalaryAdjustmentDAO.Instance.InsertSalaryAdjustment(id, name, type, amount, percent, month, year, description);
                            MessageBox.Show("Apply to" + " " + name + " " + "successfully");

                            loadSalaryAdjustment();
                            function(true);
                        }
                        catch
                        {
                            MessageBox.Show("Apply failed", "Message", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    ApplytoPosition();
                }
            }   
            
            else if (Edit == true)
            {
                if (txbID.TextLength == 0)
                {
                    MessageBox.Show("Select the ID", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        string id = txbID.Text;
                        string name = txbName.Text;
                        string type = (cbbType.SelectedItem as Adjustment).AdjustmentName;
                        int amount = Convert.ToInt32(txbAmount.Text);
                        int percent = Convert.ToInt32(txbPercent.Text);
                        int month = Convert.ToInt32(cbbMonth.Text);
                        int year = Convert.ToInt32(cbbYear.Text);
                        string description = txbDes.Text;

                        SalaryAdjustmentDAO.Instance.UpdateSalaryAdjustment(id, name, type, amount, percent, month, year, description);
                        MessageBox.Show("Edit successfully","Message", MessageBoxButtons.OK);

                        loadSalaryAdjustment();
                        function(true);
                    }
                    catch
                    {
                        MessageBox.Show("Edit failed", "Message", MessageBoxButtons.OK);
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            txbID.Clear();
            txbName.Clear();
            
            txbDes.Clear();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                panel5.Enabled = true;
                panel6.Enabled = true;
            }
            else
            {
                panel5.Enabled = false;
                panel6.Enabled = false;
                cbbDep.Text = "";                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {            
            string id = txbID.Text;

            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo))
            {
                if (txbID.TextLength == 0)
                {
                    MessageBox.Show("Select item to delete", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    string Id = txbID.Text;
                    SalaryAdjustmentDAO.Instance.DeleteSalaryAdjustment(Id);
                    loadSalaryAdjustment();
                    if(SalaryAdjustmentDAO.Instance.CheckListSalaryAdjustment() == null)
                    {
                        txbPercent.Text = "0";
                        txbAmount.Text = "0";
                    }
                }
            }
        }
    }    
}
