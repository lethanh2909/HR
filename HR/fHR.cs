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
using static HR.fChangeProfile;

namespace HR
{
    public partial class fHR : Office2007RibbonForm
    {

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        public fHR(Account acc)
        {
            this.LoginAccount = acc;
            InitializeComponent();
            ChangeAccount(acc.Type);
            label1.Text += " " + acc.DisplayName + "";
        }

        void ChangeAccount(int Type)
        {
            btnMAccount.Enabled = Type == 0;
            
        }

        public void AddNewTab(string tabname, Form namepage)
        {
            foreach (TabItem tabpage in tabControl2.Tabs)
            {
                if (tabpage.Text == tabname)
                {
                    tabControl2.SelectedTab = tabpage;
                    return;
                }
            }

            TabControlPanel newTabPanel = new TabControlPanel();
            TabItem newTabPage = new TabItem(components);
            newTabPanel.Dock = DockStyle.Fill;
            newTabPanel.Location = new System.Drawing.Point(0, 26);
            newTabPanel.Name = "panel" + tabname;
            newTabPanel.Padding = new System.Windows.Forms.Padding(1);
            newTabPanel.Size = new System.Drawing.Size(1000, 396);
            newTabPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            newTabPanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            newTabPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            newTabPanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            newTabPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            newTabPanel.Style.GradientAngle = 90;
            newTabPanel.TabIndex = 2;
            newTabPanel.TabItem = newTabPage;

            Random ran = new Random();
            newTabPage.Name = tabname + ran.Next(100000) + ran.Next(22342);
            newTabPage.AttachedControl = newTabPanel;
            newTabPage.Text = tabname;
            namepage.Dock = DockStyle.Fill;
            namepage.TopLevel = false;
            namepage.Visible = true;
            newTabPanel.Controls.Add(namepage);
            tabControl2.Controls.Add(newTabPanel);
            tabControl2.Tabs.Add(newTabPage);
            tabControl2.SelectedTab = newTabPage;
        }



        private void tabControl2_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            tabControl2.Tabs.Remove(tabControl2.SelectedTab);
        }        

        void f_updateAccount(object sender, AccountEvent e)
        {
            label1.Text = ": " + e.Acc.DisplayName;            
        }

        private void btnManageDepartment_Click(object sender, EventArgs e)
        {
            fManageDepartment f = new fManageDepartment();
            f.ShowDialog();
        }

        private void btnManagePosition_Click(object sender, EventArgs e)
        {
            fManagePosition f = new fManagePosition();
            f.ShowDialog();
        }        

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            fManageShifts f = new fManageShifts();
            AddNewTab("Manage Shifts", f);
        }       

        private void btnManageTimekeeping_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTimekeeping_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            fAssignShift f = new fAssignShift();
            AddNewTab("Assign Shift", f);
        }

        private void btnMAccount_Click(object sender, EventArgs e)
        {
            fManageAcc f = new fManageAcc();
            AddNewTab("Manage Account", f);
        }

        private void btnChangePro_Click(object sender, EventArgs e)
        {
            fChangeProfile f = new fChangeProfile(LoginAccount);
            f.UpdateAccount += f_updateAccount;
            f.ShowDialog();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonItem2_Click_1(object sender, EventArgs e)
        {
            fManageEmployee f = new fManageEmployee();
            AddNewTab("Employee", f);
        }

        private void btnSalary_Click_1(object sender, EventArgs e)
        {
            fSalary f = new fSalary();
            AddNewTab("Salary", f);
        }

        private void btnAllowance_Click_1(object sender, EventArgs e)
        {
            fAdjustAllowance f = new fAdjustAllowance();
            AddNewTab("Allowance", f);
        }

        private void btnAdjust_Click_1(object sender, EventArgs e)
        {
            fAdjustSalary f = new fAdjustSalary();
            AddNewTab("Salary adjustment", f);
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            fManageTimekeeping f = new fManageTimekeeping();
            AddNewTab("Manage Timekeeping", f);
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            fManageEarlyLate f = new fManageEarlyLate();
            AddNewTab("Manage EarlyAndLate", f);
        }

        private void btnOvertime_Click(object sender, EventArgs e)
        {
            fManageOvertime f = new fManageOvertime();
            AddNewTab("Overtime", f);
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            fSalaryCalculation f = new fSalaryCalculation();
            AddNewTab("Salary Calculation", f);
        }
    }
        
}
