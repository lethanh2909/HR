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

namespace HR
{
    public partial class fChangeProfile : Office2007Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value;  }
        }

        public fChangeProfile(Account acc)
        {
            InitializeComponent();

            LoginAccount = acc;
            ChangeProfile(loginAccount);
        }

        void ChangeProfile(Account acc)
        {
            txbUsername.Text = LoginAccount.UserName;
            txbDisname.Text = LoginAccount.DisplayName;
        }

        void UpdateInfoAccount()
        {
            string username = txbUsername.Text;
            string displayname = txbDisname.Text;
            string password = txbPassword.Text;
            string newpass = txbNewpassword.Text;
            string confirmpass = txbConpassword.Text;

            if (!newpass.Equals(confirmpass))
            {
                MessageBox.Show(" Please re-enter the correct password with the new password!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(username, displayname, password, newpass))
                {
                    MessageBox.Show("Update successfully");
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(username)));
                }
                else
                {
                    MessageBox.Show("Please enter the correct password!");
                }
            }

        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateInfoAccount();
        }

        public class AccountEvent : EventArgs
        {
            private Account acc;

            public Account Acc
            {
                get { return acc; }
                set { acc = value; }
            }

            public AccountEvent(Account acc)
            {
                this.Acc = acc;
            }
        }
    }
}
