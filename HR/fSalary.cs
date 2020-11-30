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
using DevComponents.DotNetBar.Controls;
using HR.DAO;
using HR.DTO;


namespace HR
{
    public partial class fSalary : Office2007Form
    {
        BindingSource Salary = new BindingSource();
        public fSalary()
        {
            InitializeComponent();
            cbbSearchBy.SelectedIndex = 0;
            LoadFomulaIntoCb();
            dtgvSalary.DataSource = Salary;
            LoadSalary();
            AddBinding();
            loadtxb();
            function(true);
        }

        void LoadFomulaIntoCb()
        {
           // List<SalaryFormula> listDepartment = SalaryFormulaDAO.Instance.GetListAllFormula();
           // cbbFormula.DataSource = listDepartment;
           // cbbFormula.DisplayMember = "SformulaName";
        }

        void LoadSalary()
        {
            Salary.DataSource = SalaryDAO.Instance.GetPivot();                      
        }

        void AddBinding()
        {
            if(SalaryDAO.Instance.CheckSalaryTable() != null)
            {
                labelid.DataBindings.Add(new Binding("Text", dtgvSalary.DataSource, "EmpId", true, DataSourceUpdateMode.Never));
                labFist.DataBindings.Add(new Binding("Text", dtgvSalary.DataSource, "FirstName", true, DataSourceUpdateMode.Never));
                labLast.DataBindings.Add(new Binding("Text", dtgvSalary.DataSource, "LastName", true, DataSourceUpdateMode.Never));
                txbBaseSal.DataBindings.Add(new Binding("Text", dtgvSalary.DataSource, "Base salary", true, DataSourceUpdateMode.Never));
                cbbFormula.DataBindings.Add(new Binding("Text", dtgvSalary.DataSource, "Salary formula", true, DataSourceUpdateMode.Never));
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (SalaryDAO.Instance.CheckSalaryTable() != null)
            {
                ResetflpTable();                
                ReupdateSalryWhenAddAll();
                ResetDtgv();
            }
            else
            {
                SalaryDAO.Instance.LoadSalary();
            }
            
        }

        void ResetDtgv()
        {            
            dtgvSalary.DataSource = Salary;
            LoadSalary();
        }

        void ResetflpTable()
        {
            flpTable.Controls.Clear();
            loadtxb();
    }

        void loadtxb()
        {
            List<Allowance> allowances = AllowanceDAO.Instance.GetListAllowance();
            Salary.DataSource = SalaryDAO.Instance.GetPivot();
            foreach (Allowance item in allowances)
            {                
                TextBoxX txb = new TextBoxX() { Width = 100, Height = 50 };
                txb.Name = item.AllName;

                Label la = new Label() { Width = 70 };
                la.Text = item.AllName;
                la.Font = new Font("Verdana", 8);
                la.TextAlign = ContentAlignment.MiddleRight;

                string column = item.AllName;
                if (SalaryDAO.Instance.CheckSalaryTable() != null)
                {
                    txb.DataBindings.Add(new Binding("Text", dtgvSalary.DataSource, column, true, DataSourceUpdateMode.Never));
                }

                flpTable.Controls.Add(la);
                flpTable.Controls.Add(txb);                
            }
        }

        void ReupdateSalryWhenAddAll()
        {
            List<Salary> salary = SalaryDAO.Instance.GetListSalary();
            foreach (Salary item in salary)
            {
                if (item.SalBase != 0 || item.SalFomula != "empty")
                {
                    SalaryDAO.Instance.UpdateSalaryWhenAddNewAll(item.SalBase, item.SalFomula, item.EmpId);
                }                
            }
        }

        private void function(bool b)
        {
            btnSave.Enabled = btnCancel.Enabled = txbBaseSal.Enabled = cbbFormula.Enabled = flpTable.Enabled = !b;

            btnEdit.Enabled = btnDelete.Enabled = b;
        }

        private bool Add = false, Edit = false;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ResetflpTable();
            Add = false;
            Edit = true;
            function(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (Edit == true)
            {
                if (labelid.Text == "")
                {
                    MessageBox.Show("Enter the allowance name", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    string empid = labelid.Text;
                    int BaseSal = Convert.ToInt32(txbBaseSal.Text);
                    string formula = Convert.ToString(cbbFormula.Text);

                    List<Allowance> allowances = AllowanceDAO.Instance.GetListAllowance();                    
                    foreach (Allowance item in allowances)
                    {
                        TextBoxX txb = new TextBoxX() { };
                        txb.Name = item.AllName;
                        string txbAmount = ((TextBox)flpTable.Controls[txb.Name]).Text;

                        string alltype = item.AllName;
                        int amount = Convert.ToInt32(txbAmount);
                        //ResetflpTable();
                        SalaryDAO.Instance.UpdateSalary(empid, alltype, amount, formula, BaseSal);
                    }

                    MessageBox.Show("Edit successfully");
                    LoadSalary();
                    function(true);                  
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txbSearch.Text;           


            switch (cbbSearchBy.SelectedItem.ToString().Trim())
            {
                case "Department Name":
                    Salary.DataSource = SalaryDAO.Instance.SeacrhSalaryByDepaName(search);
                    break;

                case "Position Name":
                    Salary.DataSource = SalaryDAO.Instance.SeacrhSalaryByPosiName(search);
                    break;

                case "Employee ID":
                    Salary.DataSource = SalaryDAO.Instance.SeacrhSalaryByEmpName(search);
                    break;
            }
        }

        private void btnEditSalFormula_Click(object sender, EventArgs e)
        {
            fModifySalaryFormula f = new fModifySalaryFormula();
            f.ShowDialog();
        }

        private void cbbFormula_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }  
}
