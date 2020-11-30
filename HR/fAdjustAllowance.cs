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
using Mathematical.Expressions;

namespace HR
{
    public partial class fAdjustAllowance : Office2007Form
    {
        BindingSource AllowanceList = new BindingSource();
        DataTable Allowance = AllowanceDAO.Instance.GetTableAllowance();

        public fAdjustAllowance()
        {
            InitializeComponent();
            function(true);
            dtgvAllowance.DataSource = AllowanceList;

            loadAllowance();
            AddAllowanceBinding();
            LoadFormulaIntoCb();
        }

        void loadAllowance()
        {
            AllowanceList.DataSource = AllowanceDAO.Instance.GetListAllowance();
            //dtgvAllowance.Columns[0].Visible = false;
        }

        void AddAllowanceBinding()
        {
            //string id = Convert.ToString(dtgvAllowance.Rows[dtgvAllowance.CurrentRow.Index].Cells[0].Value);
            
            txbAllId.DataBindings.Add(new Binding("Text", dtgvAllowance.DataSource, "AllId", true, DataSourceUpdateMode.Never));
            txbAllName.DataBindings.Add(new Binding("Text", dtgvAllowance.DataSource, "AllName", true, DataSourceUpdateMode.Never));            
            

            Binding bind = new Binding("Checked", dtgvAllowance.DataSource, "AllTax", true, DataSourceUpdateMode.Never);
            bind.Format += (s, e) => {
                if(e.Value != null)
                {
                    e.Value = Convert.ToInt32(e.Value) == 1;
                }
                
            };
            ckBoxTax.DataBindings.Add(bind);

            txbAmount.DataBindings.Add(new Binding("Text", dtgvAllowance.DataSource, "Amount", true, DataSourceUpdateMode.Never));
            cbbFormula.DataBindings.Add(new Binding("Text", dtgvAllowance.DataSource, "AllFormulaName", true, DataSourceUpdateMode.Never));
            txbFormula.DataBindings.Add(new Binding("Text", dtgvAllowance.DataSource, "AllFormula", true, DataSourceUpdateMode.Never));
            
        }

        void LoadFormulaIntoCb()
        {
            List<AllowanceFormula> listFormula = AllowanceFormulaDAO.Instance.GetListAllFormula();

            cbbFormula.DataSource = listFormula;
            cbbFormula.DisplayMember = "FormulaName";
            
        }

        private void cbbFormula_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            AllowanceFormula selected = cb.SelectedItem as AllowanceFormula;
            id = selected.FormulaId;

            DataTable formula = AllowanceFormulaDAO.Instance.GetFormula(id);
            foreach (DataRow dataRow in formula.Rows)
            {
                string allformula = Convert.ToString(dataRow["Formula"]);
                txbFormula.Text = allformula;
            }
        }

        private void function(bool b)
        {
            btnSave.Enabled = btnCancel.Enabled = txbAllId.Enabled = txbAllName.Enabled = ckBoxTax.Enabled = txbAmount.Enabled = cbbFormula.Enabled = !b;

            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = b;
        }

        private bool Add = false, Edit = false;
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txbAllId.ReadOnly = false;
            txbAllId.Clear();
            txbAllName.Clear();
            txbAmount.Clear();
            ckBoxTax.Checked = false;

            Add = true;
            Edit = false;
            function(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txbAllId.ReadOnly = true;
            Add = false;
            Edit = true;
            function(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo))
            {
                if (txbAllId.TextLength == 0)
                {
                    MessageBox.Show("Select item to delete", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    int allId = Convert.ToInt32(txbAllId.Text);
                    AllowanceDAO.Instance.DeleteAllowance(allId);
                    SalaryDAO.Instance.DeleteSalaryByAllId(allId);
                    loadAllowance();
                }
            }            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Add == true)
            {
                if (txbAllName.TextLength == 0)
                {
                    MessageBox.Show("Enter the allowance name", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        int allId = Convert.ToInt32(txbAllId.Text);
                        string allName = txbAllName.Text;
                        int amount = Convert.ToInt32(txbAmount.Text);
                        string allFormulaName = cbbFormula.Text;
                        string allFormula = txbFormula.Text;
                        int allTax;
                        if (ckBoxTax.Checked == true)
                        {
                            allTax = 1;
                            AllowanceDAO.Instance.InsertAllowance(allId, allName, allTax, amount, allFormulaName, allFormula);
                            SalaryDAO.Instance.LoadSalaryWhenAddAllowance(allName, allId);
                            MessageBox.Show("Add successfully");
                            function(true);
                        }
                        else
                        {
                            allTax = 0;
                            AllowanceDAO.Instance.InsertAllowance(allId, allName, allTax, amount, allFormulaName, allFormula);
                            SalaryDAO.Instance.LoadSalaryWhenAddAllowance(allName, allId);
                            MessageBox.Show("Add successfully");
                            function(true);
                        }                      
                        
                        loadAllowance();
                    }
                    catch
                    {
                        MessageBox.Show("Add failed");
                    }
                }
            }
            else if (Edit == true)
            {
                if (txbAllName.TextLength == 0)
                {
                    MessageBox.Show("Enter the allowance name", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        int allId = Convert.ToInt32(txbAllId.Text);
                        string allName = txbAllName.Text;
                        int amount = Convert.ToInt32(txbAmount.Text);
                        string allFormulaName = cbbFormula.Text;
                        string allFormula = txbFormula.Text;
                        int allTax; 
                        
                        if (ckBoxTax.Checked == true)
                        {
                            allTax = 1;
                            AllowanceDAO.Instance.UpdateAllowance(allId, allName, allTax, amount, allFormulaName, allFormula);
                            AllowanceDAO.Instance.UpadateSalaryAllowance();
                            MessageBox.Show("Edit successfully");
                            function(true);
                        }
                        else
                        {
                            allTax = 0;
                            AllowanceDAO.Instance.UpdateAllowance(allId, allName, allTax, amount, allFormulaName, allFormula);
                            AllowanceDAO.Instance.UpadateSalaryAllowance();
                            MessageBox.Show("Edit successfully");
                            function(true);
                        }
                        
                        loadAllowance();
                    }
                    catch
                    {
                        MessageBox.Show("Edit failed");
                    }
                }
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            fModifyAllFormula f = new fModifyAllFormula();
            f.ShowDialog();
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
