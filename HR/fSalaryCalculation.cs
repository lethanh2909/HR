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
using HR.DAO;
using HR.DTO;
using Mathematical.Expressions;

namespace HR
{
    public partial class fSalaryCalculation : Office2007Form
    {
        public fSalaryCalculation()
        {
            InitializeComponent();            
            LoadDepartmentIntoCb();
            SetCbbYear();
        }


        void loadSummaryDtgv(string empid, int month, int year)
        {
            dtgvSummary.DataSource = SummaryDAO.Instance.GetListSummary(empid, month, year);
        }

        void LoadOTdtgv(string empid, int month, int year)
        {
            dtgvOT.DataSource = OvertimeSummaryDAO.Instance.GetListOTSummary(empid, month, year);
            dtgvOT.Columns[0].Visible = false;
            dtgvOT.Columns[1].Visible = false;
            dtgvOT.Columns[2].Visible = false;
            dtgvOT.Columns[5].Visible = false;
            dtgvOT.Columns[7].Visible = false;
            dtgvOT.Columns[8].Visible = false;

        }

        void LoadAlldtgv(string empid, int month, int year)
        {
            dtgvAll.DataSource = AllowanceSummaryDAO.Instance.GetListAllSummary(empid, month, year);
            dtgvAll.Columns[0].Visible = false;
            dtgvAll.Columns[1].Visible = false;
            dtgvAll.Columns[2].Visible = false;
            dtgvAll.Columns[5].Visible = false;
            dtgvAll.Columns[6].Visible = false;
            dtgvAll.Columns[7].Visible = false;
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

            dtgvEmployee.DataSource = EmployeeDAO.Instance.GetListEmployeeByPosID(id);
            AtrDtgvEmp();
        }

        void SetCbbYear()
        {
            cbbYear.DataSource = Enumerable.Range(1983, DateTime.Now.Year - 1983 + 1).ToList();
            cbbYear.SelectedItem = DateTime.Now.Year;

            cbbMonth.DataSource = Enumerable.Range(1, DateTime.Now.Month + 1).ToList();
            cbbMonth.SelectedItem = DateTime.Now.Month;
        }

        void LoadSummary()
        {
            string StartDate = DatePickerFrom.Text;
            DateTime datefrom = DateTime.ParseExact(StartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string DateFrom = datefrom.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

            string EndDate = DatePickerTo.Text;
            DateTime dateto = DateTime.ParseExact(EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string DateTo = dateto.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

            List<Employee> list = EmployeeDAO.Instance.GetListEmployee();
            foreach (Employee item in list)
            {
                object Attendance = SummaryDAO.Instance.CountAttendance(DateFrom, DateTo, item.EmpId);
                int Attend = Convert.ToInt32(Attendance);

                if (Attend > 0)
                {
                    string EmpId = item.EmpId;
                    string FirstName = item.FirstName;
                    string LastName = item.LastName;
                    int Month = Convert.ToInt32(cbbMonth.Text);
                    int Year = Convert.ToInt32(cbbYear.Text);

                    DataTable getBaseSalary = SalaryDAO.Instance.GetBaseSalary(item.EmpId);
                    int BaseSalary = Convert.ToInt32(getBaseSalary.Rows[0]["SalBase"]);
                    string SalaryFormula = getBaseSalary.Rows[0]["SalFomula"].ToString();

                    object Absence = SummaryDAO.Instance.CountAbsence(DateFrom, DateTo, item.EmpId);
                    int Abs = Convert.ToInt32(Absence);

                    SummaryDAO.Instance.InsertSummary(EmpId, FirstName, LastName, BaseSalary, Attend, Abs, SalaryFormula, Month, Year);
                }
            }
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            int Month = Convert.ToInt32(cbbMonth.Text);
            int Year = Convert.ToInt32(cbbYear.Text);
            

            if (dtgvEmployee.DataSource != null)
            {
                string empid = Convert.ToString(dtgvEmployee.Rows[dtgvEmployee.CurrentRow.Index].Cells[0].Value);

                SummaryDAO.Instance.DeletePersonalSummary(empid, Month, Year);
                OvertimeSummaryDAO.Instance.DeleteOTSummary(empid, Month, Year);
                AllowanceSummaryDAO.Instance.DeleteAllSummary(empid, Month, Year);

                LoadSummary();
                loadOTsummary();
                loadAllsummary();

                loadSummaryDtgv(empid, Month, Year);
                LoadOTdtgv(empid, Month, Year);
                LoadAlldtgv(empid, Month, Year);
                dtgvSummary.Columns[0].Visible = false;
            }
        }

        void AtrDtgvEmp()
        {
            for (int i = 4; i < dtgvEmployee.Columns.Count; i++)
            {
                dtgvEmployee.Columns[i].Visible = false;
            }
            dtgvEmployee.Columns[1].Visible = false;
            dtgvEmployee.Columns[0].Width = 50;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete?", "Message", MessageBoxButtons.YesNo))
                {
                    int id = Convert.ToInt32(dtgvSummary.Rows[dtgvSummary.CurrentRow.Index].Cells[0].Value);
                    SummaryDAO.Instance.DeleteCurrentSummary(id);

                    int Month = Convert.ToInt32(cbbMonth.Text);
                    int Year = Convert.ToInt32(cbbYear.Text);
                    string empid = Convert.ToString(dtgvEmployee.Rows[dtgvEmployee.CurrentRow.Index].Cells[0].Value);

                    loadSummaryDtgv(empid, Month, Year);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Failed!! Select a row to delete", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void buttonX1_Click()
        {
            int year = 2020;
            int month = 11;
            int daysInMonth = 0;
            int days = DateTime.DaysInMonth(year, month);
            for (int i = 1; i <= days; i++)
            {
                DateTime day = new DateTime(year, month, i);
                if (day.DayOfWeek != DayOfWeek.Sunday)
                {
                    daysInMonth++;
                }
            }

            int Month = Convert.ToInt32(cbbMonth.Text);
            int Year = Convert.ToInt32(cbbYear.Text);
            string empid = Convert.ToString(dtgvEmployee.Rows[dtgvEmployee.CurrentRow.Index].Cells[0].Value);

            List<Summary> list = SummaryDAO.Instance.GetListSummary(empid, Month, Year);
            if(list !=null)
            {
                foreach(Summary item in list)
                {
                    ExpressionEval eval = new ExpressionEval(item.SalaryFormula);
                    eval.SetVariable("a", item.BaseSalary);
                    eval.SetVariable("b", daysInMonth);
                    eval.SetVariable("c", item.Attendance);
                    //textBox1.Text = Convert.ToString(eval.Evaluate());
                }
            }      
            
        }




        void loadOTsummary()
        {
            List<OvertimeType> list = OvertimeTypeDAO.Instance.GetListOvertimeType();

            foreach(OvertimeType item in list)
            {
                string empid = Convert.ToString(dtgvEmployee.Rows[dtgvEmployee.CurrentRow.Index].Cells[0].Value);

                DataTable employee = SalaryDAO.Instance.GetBaseSalary(empid);

                string FirstName = Convert.ToString(employee.Rows[0]["FirstName"]);
                string LastName = Convert.ToString(employee.Rows[0]["LastName"]);
                int BaseSalary = Convert.ToInt32(employee.Rows[0]["SalBase"]);
                string OTtype = Convert.ToString(item.OvertimeValue);

                int value = Convert.ToInt32(item.OvertimeValue);

                int Month = Convert.ToInt32(cbbMonth.Text);
                int Year = Convert.ToInt32(cbbYear.Text);                

                object Hour = OvertimeSummaryDAO.Instance.CountOT(item.Overtimetype);
                if(!(Hour is DBNull))
                {
                    int hours = Convert.ToInt32(Hour);

                    int perHour = (BaseSalary / 26) / 8;
                    int Amount = (perHour * hours * value)/100;
                   
                    OvertimeSummaryDAO.Instance.InsertOTSummary(empid, FirstName, LastName, OTtype, hours, BaseSalary, Amount, Month, Year);                    
                }
            }
        }

        void loadAllsummary()
        {
            List<Allowance> list = AllowanceDAO.Instance.GetListAllowance();

            foreach(Allowance item in list)
            {
                string empid = Convert.ToString(dtgvEmployee.Rows[dtgvEmployee.CurrentRow.Index].Cells[0].Value);
                DataTable employee = SalaryDAO.Instance.GetBaseSalary(empid);
                string FirstName = Convert.ToString(employee.Rows[0]["FirstName"]);
                string LastName = Convert.ToString(employee.Rows[0]["LastName"]);

                int allamount = Convert.ToInt32(employee.Rows[0]["Allamount"]);

                int Month = Convert.ToInt32(cbbMonth.Text);
                int Year = Convert.ToInt32(cbbYear.Text);

                AllowanceSummaryDAO.Instance.InsertAllSummary(empid, FirstName, LastName, item.AllName, allamount, item.AllFormula, Month, Year);
            }
        }
    }
}
