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
using HR.DTO;
using HR.DAO;
using System.Globalization;

namespace HR
{
    public partial class fAssignShift : Office2007Form
    {
        public fAssignShift()
        {
            InitializeComponent();
            
            LoadShiftIntoCb();
            LoadDepartmentIntoCb();
            panel6.Enabled = false;
            cbbDep.Text = "";
            cbbPos.Text = "";
            checkBox1.Checked = false;
        }

        void LoadEmployeeTo(int id)
        {
            if(checkBox1.Checked == true)
            {
                List<Employee> list = EmployeeDAO.Instance.GetListEmployeeByPosID(id);
                List<Employee> newlist = new List<Employee>();
                foreach (Employee item in list)
                {
                    if (ckbOnly.Checked == true)
                    {
                        if (ShiftEmployeeDAO.Instance.CheckShiftEmployee(item.EmpId) == null)
                        {
                            newlist.Add(item);
                        }
                    }
                    else
                    {
                        newlist.Add(item);
                    }
                }
                dtgvEmployee.DataSource = newlist;
            }
            else
            {
                List<Employee> list = EmployeeDAO.Instance.GetListEmployee();
                List<Employee> newlist = new List<Employee>();
                foreach (Employee item in list)
                {
                    if (ckbOnly.Checked == true)
                    {
                        if (ShiftEmployeeDAO.Instance.CheckShiftEmployee(item.EmpId) == null)
                        {
                            newlist.Add(item);
                        }
                    }
                    else
                    {
                        newlist.Add(item);
                    }
                }
                dtgvEmployee.DataSource = newlist;
            }
            
            
            for (int i = 4; i < dtgvEmployee.Columns.Count; i++)
            {
                dtgvEmployee.Columns[i].Visible = false;
            }
            dtgvEmployee.Columns[1].Visible = false;
            dtgvEmployee.Columns[0].Width = 50;
        }

        void LoadDepartmentIntoCb()
        {
            List<Department> listDepartment = DepartmentDAO.Instance.GetListDepartment();
            cbbDep.DataSource = listDepartment;
            cbbDep.DisplayMember = "DepartmentName";            
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
            
        }

        private void cbbPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Position selected = cb.SelectedItem as Position;
            id = selected.ID;
            textBox2.Text = Convert.ToString(id);            
        }

        void LoadShiftIntoCb()
        {
            List<WorkShift> listShift = WorkShiftDAO.Instance.GetListShift();
            cbbShift.DataSource = listShift;
            cbbShift.DisplayMember = "ShiftName";
        }

        private void cbbShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            WorkShift selected = cb.SelectedItem as WorkShift;
            id = selected.ShiftId;
            textBox1.Text = Convert.ToString(id);
            LoadShiftEmployee(id);
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                string Empid = Convert.ToString(dtgvEmployee.Rows[dtgvEmployee.CurrentRow.Index].Cells[0].Value);
                string FirstName = Convert.ToString(dtgvEmployee.Rows[dtgvEmployee.CurrentRow.Index].Cells[2].Value);
                string LastName = Convert.ToString(dtgvEmployee.Rows[dtgvEmployee.CurrentRow.Index].Cells[3].Value);

                string ShiftName = cbbShift.Text;

                string StartDate = DatePickerFrom.Text;
                DateTime datefrom = DateTime.ParseExact(StartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string DateStart = datefrom.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                string EndDate = DatePickerTo.Text;
                DateTime dateto = DateTime.ParseExact(EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string DateEnd = dateto.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                int ShiftId = Convert.ToInt32(textBox1.Text);

                ShiftEmployeeDAO.Instance.InsertShiftEmployee(Empid, FirstName, LastName, ShiftName, DateStart, DateEnd, ShiftId);

                int sid = Convert.ToInt32(textBox1.Text);
                LoadShiftEmployee(sid);
                int id = Convert.ToInt32(textBox2.Text);
                LoadEmployeeTo(id);
            }
            catch
            {
                MessageBox.Show("Select employee to assign", "Message", MessageBoxButtons.YesNo);
            }

        }

        void LoadShiftEmployee(int id)
        {
            dtgvShiftEmployee.DataSource = ShiftEmployeeDAO.Instance.GetListShiftEmployeeByShiftID(id);
            dtgvShiftEmployee.Columns[0].Visible = false;
        }

        private void btnUnassign_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo))
                {
                    int id = Convert.ToInt32(dtgvShiftEmployee.Rows[dtgvShiftEmployee.CurrentRow.Index].Cells[0].Value);

                    ShiftEmployeeDAO.Instance.DeleteShiftEmployee(id);
                    int sid = Convert.ToInt32(textBox1.Text);
                    LoadShiftEmployee(sid);
                    int posid = Convert.ToInt32(textBox2.Text);
                    LoadEmployeeTo(posid);
                }
            }
            catch (Exception) { }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                panel6.Enabled = true;
            }
            else
            {
                panel6.Enabled = false;
                cbbDep.Text = "";
                cbbPos.Text = "";
            }
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox2.Text);
            LoadEmployeeTo(id);
        }
    }
}
