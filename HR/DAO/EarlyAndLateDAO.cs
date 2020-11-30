using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAO
{
    public class EarlyAndLateDAO
    {
        private static EarlyAndLateDAO instance;

        public static EarlyAndLateDAO Instance
        {
            get { if (instance == null) instance = new EarlyAndLateDAO(); return instance; }
            private set { instance = value; }
        }

        private EarlyAndLateDAO() { }

        public bool LoadEarlyAndLate(string Datefrom, string Dateto)
        {
            string query = string.Format("exec USP_LoadEarlyAndLate '{0}' , '{1}'", Datefrom, Dateto);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<EarlyAndLate> GetListEarlyAndLate()
        {
            List<EarlyAndLate> list = new List<EarlyAndLate>();

            string query = "select * from EarlyAndLate";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                EarlyAndLate ea = new EarlyAndLate(item);
                list.Add(ea);
            }

            return list;
        }

        public DataTable GetTableEarlyAndLate()
        {
            string query = "select * from EarlyAndLate";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable FilteredEarlyAndLate(string Datefrom, string Dateto)
        {
            string query = string.Format("exec USP_FilteredEarlyAndLate '{0}' , '{1}'", Datefrom, Dateto);
            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            return data;
        }

        public EarlyAndLate CheckNullEarlyAndLate()
        {
            EarlyAndLate el = null;

            string query = "select * from EarlyAndLate";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                el = new EarlyAndLate(item);
                return el;
            }

            return el;
        }

        public bool UpdateEarlyLate(int late, int early, string date)
        {
            string query = string.Format("UPDATE dbo.EarlyAndLate SET LateIn = {0}, EarlyOut = {1} WHERE WorkDay = '{2}'", late, early, date);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ConfirmEarlyLate(int ConfirmLateIn, int ConfirmEarlyOut, int id)
        {
            string query = string.Format("UPDATE dbo.EarlyAndLate SET ConfirmedLateIn = {0}, ConfirmedEarlyOut = {1} WHERE ELid = '{2}'", ConfirmLateIn, ConfirmEarlyOut, id);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteEarlyLate(string Datefrom, string Dateto)
        {
            string query = string.Format("exec USP_DeleteEarlyAndLate '{0}' , '{1}'", Datefrom, Dateto);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
