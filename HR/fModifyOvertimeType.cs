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
    public partial class fModifyOvertimeType : Office2007Form
    {
        BindingSource OvertimeType = new BindingSource();
        public fModifyOvertimeType()
        {
            InitializeComponent();
            dtgvOTtype.DataSource = OvertimeType;
            loadtype();
            addBinding();
        }

        void loadtype()
        {
            OvertimeType.DataSource = OvertimeTypeDAO.Instance.GetListOvertimeType();
            dtgvOTtype.Columns[0].Width = 50;
        }

        void addBinding()
        {
            txbId.DataBindings.Add(new Binding("Text", dtgvOTtype.DataSource, "Typeid", true, DataSourceUpdateMode.Never));
            txbType.DataBindings.Add(new Binding("Text", dtgvOTtype.DataSource, "Overtimetype", true, DataSourceUpdateMode.Never));
            txbValue.DataBindings.Add(new Binding("Text", dtgvOTtype.DataSource, "OvertimeValue", true, DataSourceUpdateMode.Never));
        }

        void AddType(string type, int value)
        {
            if (OvertimeTypeDAO.Instance.InsertType(type, value))
            {
                MessageBox.Show("Add successfully");
            }
            else
            {
                MessageBox.Show("Add failed");
            }           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {            
            string type = txbType.Text;
            int value = Convert.ToInt32(txbValue.Text);

            AddType(type, value);
            loadtype();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbId.Text);
            string type = txbType.Text;
            int value = Convert.ToInt32(txbValue.Text);
            EditType(id, type, value);
            loadtype();
        }

        void EditType(int id, string type, int value)
        {
            if (OvertimeTypeDAO.Instance.UpdateType(id, type, value))
            {
                MessageBox.Show("Edit successfully");
            }
            else
            {
                MessageBox.Show("Edit failed");
            }
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
                    OvertimeTypeDAO.Instance.DeleteType(id);
                    loadtype();
                }
            }
        }
    }
}
