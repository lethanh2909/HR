using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAO
{
    public class OvertimeTypeDAO
    {
        private static OvertimeTypeDAO instance;

        public static OvertimeTypeDAO Instance
        {
            get { if (instance == null) instance = new OvertimeTypeDAO(); return instance; }
            private set { instance = value; }
        }

        private OvertimeTypeDAO() { }

        public List<OvertimeType> GetListOvertimeType()
        {
            List<OvertimeType> list = new List<OvertimeType>();

            string query = "select * from OvertimeType";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                OvertimeType overtimeType = new OvertimeType(item);
                list.Add(overtimeType);
            }

            return list;
        }

        public List<OvertimeType> GetTypeOvertimeType(int id)
        {
            List<OvertimeType> list = new List<OvertimeType>();

            string query = "select * from OvertimeType where Typeid = " + id;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                OvertimeType overtimeType = new OvertimeType(item);
                list.Add(overtimeType);
            }

            return list;
        }

        public bool InsertType(string overtimeType, int Value)
        {
            string query = string.Format("INSERT dbo.OvertimeType (OvertimeType, Value) VALUES  ( N'{0}', {1})", overtimeType, Value);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateType(int id, string overtimeType, int Value)
        {
            string query = string.Format("UPDATE dbo.OvertimeType SET OvertimeType = N'{0}', Value = {1} WHERE Typeid = {2}", overtimeType, Value, id);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteType(int id)
        {
            string query = string.Format("Delete dbo.OvertimeType WHERE Typeid = {0}", id);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
