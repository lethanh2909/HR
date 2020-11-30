using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using HR.DAO;
using HR.DTO;

namespace HR
{
    public partial class fManageEmployee : Office2007Form
    {
        BindingSource EmployeeInfo = new BindingSource();

        public fManageEmployee()
        {
            InitializeComponent();

            showtreeview();        
            
        }

        void LoadDepartmentIntoCb()
        {
            List<Department> listDepartment = DepartmentDAO.Instance.GetListDepartment();
            cbbDepartment.DataSource = listDepartment;
            cbbDepartment.DisplayMember = "DepartmentName";
        }
        private void cbbDepartment_SelectedIndexChanged(object sender, EventArgs e)
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
            cbbPosition.DataSource = listPosition;
            cbbPosition.DisplayMember = "PositionName";

            if (listPosition == null)
            {
                cbbPosition.Items.Clear();
            }
            
        }

        private void showtreeview()
        {
            TreeNode Newnode = new TreeNode("Company structure");

            treeView.Nodes.Clear();
            loadtreeview(Newnode);
            treeView.Nodes.Add(Newnode);
            treeView.ExpandAll();         
            
        }

        void loadtreeview(TreeNode Newnode)
        {            
            DataTable department_node = DepartmentDAO.Instance.GetTableDepartment();                        

            for (int i = 0; i < department_node.Rows.Count; i++)
            {
                Newnode.Nodes.Add(department_node.Rows[i][1].ToString());
                Newnode.Nodes[i].Tag = "1";

                int id = Convert.ToInt32(department_node.Rows[i][0]);

                DataTable position_node = PositionDAO.Instance.GetTablePosition(id);

                for (int j = 0; j < position_node.Rows.Count; j++)
                {
                    Newnode.Nodes[i].Nodes.Add(position_node.Rows[j][1].ToString());
                    Newnode.Nodes[i].Nodes[j].Tag = "2";

                    int ids = Convert.ToInt32(position_node.Rows[j][0]);

                    DataTable employee_node = EmployeeDAO.Instance.GetTableEmployee(ids);

                    for (int k = 0; k < employee_node.Rows.Count; k++)
                    {
                        Newnode.Nodes[i].Nodes[j].Nodes.Add(employee_node.Rows[k][0].ToString(), employee_node.Rows[k][2].ToString() +" "+ employee_node.Rows[k][3].ToString());
                        Newnode.Nodes[i].Nodes[j].Nodes[k].Tag = "3";
                    }
                }                
            }
            
        }      
               

        public void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectednode = this.treeView.SelectedNode;
            if (Convert.ToString(selectednode.Tag) == "3")
            {
                string employeename = selectednode.Text;
                string[] split = employeename.Split(new Char[] { ' ' });
                
                string firstname = split[0];
                string lastname = split[1];
                LoadDepartmentIntoCb();
                
                EmployeeInfo.DataSource = EmployeeDAO.Instance.GetListEmployeeByName(firstname, lastname);      
                      
                //AddDepartmentBinding
                txbId.DataBindings.Clear();
                txbId.DataBindings.Add(new Binding("Text", EmployeeInfo.DataSource, "EmpId", true, DataSourceUpdateMode.Never));
                txbFirstname.DataBindings.Clear();
                txbFirstname.DataBindings.Add(new Binding("Text", EmployeeInfo.DataSource, "FirstName", true, DataSourceUpdateMode.Never));
                txbLastname.DataBindings.Clear();
                txbLastname.DataBindings.Add(new Binding("Text", EmployeeInfo.DataSource, "Lastname", true, DataSourceUpdateMode.Never));
                cbbGender.DataBindings.Clear();
                cbbGender.DataBindings.Add(new Binding("Text", EmployeeInfo.DataSource, "Gender", true, DataSourceUpdateMode.Never));
                datePicker.DataBindings.Clear();
                datePicker.DataBindings.Add(new Binding("Value", EmployeeInfo.DataSource, "Dob", true, DataSourceUpdateMode.Never));
                txbCity.DataBindings.Clear();
                txbCity.DataBindings.Add(new Binding("Text", EmployeeInfo.DataSource, "City", true, DataSourceUpdateMode.Never));
                txbState.DataBindings.Clear();
                txbState.DataBindings.Add(new Binding("Text", EmployeeInfo.DataSource, "State", true, DataSourceUpdateMode.Never));
                txbHschool.DataBindings.Clear();
                txbHschool.DataBindings.Add(new Binding("Text", EmployeeInfo.DataSource, "Highschool", true, DataSourceUpdateMode.Never));
                txbUni.DataBindings.Clear();
                txbUni.DataBindings.Add(new Binding("Text", EmployeeInfo.DataSource, "University", true, DataSourceUpdateMode.Never));
                txbCollege.DataBindings.Clear();
                txbCollege.DataBindings.Add(new Binding("Text", EmployeeInfo.DataSource, "College", true, DataSourceUpdateMode.Never));
                txbNationality.DataBindings.Clear();
                txbNationality.DataBindings.Add(new Binding("Text", EmployeeInfo.DataSource, "Nationality", true, DataSourceUpdateMode.Never));
                cbbDepartment.DataBindings.Clear();
                cbbDepartment.DataBindings.Add(new Binding("Text", EmployeeInfo.DataSource, "DepaName", true, DataSourceUpdateMode.Never));
                cbbPosition.DataBindings.Clear();
                cbbPosition.DataBindings.Add(new Binding("Text", EmployeeInfo.DataSource, "PosiName", true, DataSourceUpdateMode.Never));
                
                cbbMarital.DataBindings.Clear();
                cbbMarital.DataBindings.Add(new Binding("Text", EmployeeInfo.DataSource, "Maritalstatus", true, DataSourceUpdateMode.Never));
                txbPhone.DataBindings.Clear();
                txbPhone.DataBindings.Add(new Binding("Text", EmployeeInfo.DataSource, "Phone", true, DataSourceUpdateMode.Never));
                txbEmail.DataBindings.Clear();
                txbEmail.DataBindings.Add(new Binding("Text", EmployeeInfo.DataSource, "Email", true, DataSourceUpdateMode.Never));
                txbAddress.DataBindings.Clear();
                txbAddress.DataBindings.Add(new Binding("Text", EmployeeInfo.DataSource, "Address", true, DataSourceUpdateMode.Never));
                
                string fname = txbId.Text + ".png";
                string folder = "D:\\test";
                string path = System.IO.Path.Combine(folder, fname);
                
                if (File.Exists(path))
                {                    
                    pictureBox1.Image = Image.FromFile(path);
                }
                else
                {
                    pictureBox1.Image = Image.FromFile("D:\\test\\empty.png");
                }                   
            }
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();            
            f.Filter = "*.jpeg;*.jpg;*.bmp;*.png |*.jpeg;*.jpg;*.bmp;*.png; ";
            Image File;

            if (f.ShowDialog() == DialogResult.OK)
            {                
                File = Image.FromFile(f.FileName);
                pictureBox1.Image = File;
            }            
        }

        private void function(bool b)
        {
            btnSave.Enabled = btnCancel.Enabled = btn_Browse.Enabled = txbId.Enabled = txbFirstname.Enabled = txbLastname.Enabled = txbEmail.Enabled = cbbGender.Enabled
                = txbAddress.Enabled = txbCity.Enabled = txbState.Enabled = datePicker.Enabled = txbNationality.Enabled = cbbMarital.Enabled
                = txbPhone.Enabled = txbHschool.Enabled = txbUni.Enabled = txbCollege.Enabled = cbbReligion.Enabled = cbbDepartment.Enabled = cbbPosition.Enabled = !b;

            btn_Add.Enabled = btn_Edit.Enabled = btn_Delete.Enabled = b;
        }

        private bool Add = false, Edit = false;

        private void btn_Add_Click(object sender, EventArgs e)
        {
            LoadDepartmentIntoCb();

            txbId.ReadOnly = false;

            txbId.Clear();
            txbFirstname.Clear();
            txbLastname.Clear();
            txbEmail.Clear();
            cbbGender.Text = "Select Gender";
            txbAddress.Clear();
            txbCity.Clear();
            txbState.Clear();

            txbNationality.Clear();
            cbbMarital.Text = "Select status";
            txbPhone.Clear();
            txbHschool.Clear();
            txbUni.Clear();
            txbCollege.Clear();
            cbbReligion.Text = "Select Religion";
            cbbDepartment.Text = "Select Department";
            cbbPosition.Text = "Select Position";

            Add = true;
            Edit = false;
            function(false);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            LoadDepartmentIntoCb();
            Add = false;
            Edit = true;
            function(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Add == true)
            {
                if (txbId.TextLength == 0)
                {
                    MessageBox.Show("Enter the ID", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        string fname = txbId.Text + ".png";
                        string folder = "D:\\test";
                        string path = System.IO.Path.Combine(folder, fname);
                        Image a = pictureBox1.Image;
                        a.Save(path);

                        string empId = txbId.Text;
                        string image = path;
                        string firstName = txbFirstname.Text;
                        string lastName = txbLastname.Text;
                        string email = txbEmail.Text;
                        string gender = cbbGender.Text;
                        string address = txbAddress.Text;
                        string city = txbCity.Text;
                        string state = txbState.Text;
                        DateTime dob = datePicker.Value;
                        string nationality = txbNationality.Text;
                        string maritalstatus = cbbMarital.Text;
                        string phone = txbPhone.Text;
                        string highschool = txbHschool.Text;
                        string university = txbUni.Text;
                        string college = txbCollege.Text;
                        string religion = cbbReligion.Text;
                        string depaName = cbbDepartment.Text;
                        string posiName = cbbPosition.Text;
                        int posiId = (cbbPosition.SelectedItem as Position).ID;

                        EmployeeDAO.Instance.InsertEmployee(empId, image, firstName, lastName, email, gender, address, city, state, dob, nationality, maritalstatus, phone, highschool, university, college, religion, depaName, posiName, posiId);
                        SalaryDAO.Instance.LoadSalaryWhenAddEmployee(empId, firstName, lastName, depaName, posiName);

                        MessageBox.Show("Add successfully");

                        showtreeview();
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
                if (txbId.TextLength == 0)
                {
                    MessageBox.Show("Enter the Position name", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        string fname = txbId.Text + ".png";
                        string folder = "D:\\test";
                        string path = System.IO.Path.Combine(folder, fname);

                        string empId = txbId.Text;
                        string image = path;
                        string firstName = txbFirstname.Text;
                        string lastName = txbLastname.Text;
                        string email = txbEmail.Text;
                        string gender = cbbGender.Text;
                        string address = txbAddress.Text;
                        string city = txbCity.Text;
                        string state = txbState.Text;
                        DateTime dob = datePicker.Value;
                        string nationality = txbNationality.Text;
                        string maritalstatus = cbbMarital.Text;
                        string phone = txbPhone.Text;
                        string highschool = txbHschool.Text;
                        string university = txbUni.Text;
                        string college = txbCollege.Text;
                        string religion = cbbReligion.Text;
                        string depaName = cbbDepartment.Text;
                        string posiName = cbbPosition.Text;
                        int posiId = (cbbPosition.SelectedItem as Position).ID;

                        EmployeeDAO.Instance.UpdateEmployee(empId, image, firstName, lastName, email, gender, address, city, state, dob, nationality, maritalstatus, phone, highschool, university, college, religion, depaName, posiName, posiId);
                        MessageBox.Show("Edit successfully");

                        showtreeview();
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
            txbId.ReadOnly = true;
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {            
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo))
            {
                if (txbId.TextLength == 0)
                {
                    MessageBox.Show("Select item to delete", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    string empId = txbId.Text;
                    EmployeeDAO.Instance.DeleteEmployee(empId);
                    SalaryDAO.Instance.DeleteSalaryByEmpId(empId);
                    showtreeview();
                }
            }
        }
    }
}
