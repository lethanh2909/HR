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
    public partial class fModifyAllFormula : Office2007Form
    {
        public fModifyAllFormula()
        {
            InitializeComponent();
            loadDtgv();
            addBinding();
        }

        void loadDtgv()
        {
            dtgvAllFormula.DataSource = AllowanceFormulaDAO.Instance.GetListAllFormula();
            dtgvAllFormula.Columns[1].Width = 300;
        }

        void addBinding()
        {
            txbId.DataBindings.Add(new Binding("Text", dtgvAllFormula.DataSource, "FormulaId", true, DataSourceUpdateMode.Never));
            txbDes.DataBindings.Add(new Binding("Text", dtgvAllFormula.DataSource, "FormulaName", true, DataSourceUpdateMode.Never));
            txbFormula.DataBindings.Add(new Binding("Text", dtgvAllFormula.DataSource, "Formula", true, DataSourceUpdateMode.Never));
        }

        void add(int FormulaId, string FormulaName, string Formula)
        {
            if(AllowanceFormulaDAO.Instance.InsertFor(FormulaId, FormulaName, Formula))
            {
                MessageBox.Show("Add successfully");
                loadDtgv();
            }
            else
            {
                MessageBox.Show("Add failed");
                loadDtgv();
            }            
        }

        void Edit(int FormulaId, string FormulaName, string Formula)
        {
            if (AllowanceFormulaDAO.Instance.UpdateFor(FormulaId, FormulaName, Formula))
            {
                MessageBox.Show("Edit successfully");
                loadDtgv();
            }
            else
            {
                MessageBox.Show("Edit failed");
                loadDtgv();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int FormulaId = Convert.ToInt32(txbId.Text);
            string FormulaName = Convert.ToString(txbDes);
            string Formula = Convert.ToString(txbFormula);

            add(FormulaId, FormulaName, Formula);
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            int FormulaId = Convert.ToInt32(txbId.Text);
            string FormulaName = Convert.ToString(txbDes);
            string Formula = Convert.ToString(txbFormula);

            Edit(FormulaId, FormulaName, Formula);
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
                    AllowanceFormulaDAO.Instance.DeleteFor(id);
                    loadDtgv();
                }
            }
        }
    }
}
