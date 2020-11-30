using HR.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace HR
{
    public partial class fManageAcc : Office2007Form
    {
        public fManageAcc()
        {
            InitializeComponent();

            LoadAccount();
        }

        void LoadAccount()
        {
            string query = "EXEC dbo.USP_GetAccount @Username ";

            

            dtgvAccount.DataSource = Dataprovider.Instance.ExecuteQuery(query, new object[] {"Ad"});
        }
    }
}
