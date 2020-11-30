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
    public partial class fModifySalaryFormula : Office2007Form
    {
        BindingSource SalaryFormula = new BindingSource();

        public fModifySalaryFormula()
        {
            InitializeComponent();
            function(true);
            dtgvSalaryFormula.DataSource = SalaryFormula;
            loadSalaryFormula();
            AddAdjustmentBinding();            
        }

        void loadSalaryFormula()
        {           
            SalaryFormula.DataSource = SalaryFormulaDAO.Instance.GetTableFormula();
            // spc 43
            dtgvSalaryFormula.Columns[3].Visible = false;
            dtgvSalaryFormula.Columns[2].Width = 700;
        }

        void AddAdjustmentBinding()
        {
            txbId.DataBindings.Add(new Binding("Text", dtgvSalaryFormula.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbName.DataBindings.Add(new Binding("Text", dtgvSalaryFormula.DataSource, "Formula name", true, DataSourceUpdateMode.Never));
            txbDes.DataBindings.Add(new Binding("Text", dtgvSalaryFormula.DataSource, "Description", true, DataSourceUpdateMode.Never));            
        }

        private void function(bool b)
        {
            btnSave.Enabled = btnCancel.Enabled = txbId.Enabled = txbName.Enabled = txbDes.Enabled = !b;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = b;
        }

        private bool Add = false, Edit = false;

             
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txbId.Clear();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo))
            {
                if (txbId.TextLength == 0)
                {
                    MessageBox.Show("Select item to delete", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    int id = Convert.ToInt32(txbId.Text);
                    SalaryFormulaDAO.Instance.DeleteSalaryFormula(id);
                    loadSalaryFormula();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Add == true)
            {
                if (txbName.TextLength == 0)
                {
                    MessageBox.Show("Enter the Formula name", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        int id = Convert.ToInt32(txbId.Text);
                        string name = txbName.Text;
                        string formula = "";
                        string des = txbDes.Text;
                        SalaryFormulaDAO.Instance.InsertSalaryFormula(id, name, des, formula);
                        MessageBox.Show("Add successfully");
                        loadSalaryFormula();
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
                if (txbName.TextLength == 0)
                {
                    MessageBox.Show("Enter the Formula name", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        int id = Convert.ToInt32(txbId.Text);
                        string name = txbName.Text;
                        string des = txbDes.Text;
                        string formula = "";
                        SalaryFormulaDAO.Instance.UpdateSalaryFormula(id, name, des, formula);
                        MessageBox.Show("Edit successfully", "Message", MessageBoxButtons.OK);
                        loadSalaryFormula();
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

        
    }    
}
