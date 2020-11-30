using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAO
{
    public class AdjustmentDAO
    {
        private static AdjustmentDAO instance;

        public static AdjustmentDAO Instance
        {
            get { if (instance == null) instance = new AdjustmentDAO(); return instance; }
            private set { instance = value; }
        }

        private AdjustmentDAO() { }


        public List<Adjustment> GetListAdjustment()
        {
            List<Adjustment> list = new List<Adjustment>();

            string query = "select * from Adjustment";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Adjustment adjustment = new Adjustment(item);
                list.Add(adjustment);
            }

            return list;
        }
        public bool InsertAdjustment(int id, string name, string type)
        {
            string query = string.Format("INSERT dbo.Adjustment ( AdjustmentId, AdjustmentType, AdjustmentDes ) VALUES  ( N'{0}', '{1}', '{2}')", id, type, name);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateAdjustment(int id, string name, string type)
        {
            string query = string.Format("UPDATE dbo.Adjustment SET AdjustmentId = N'{0}', AdjustmentType = '{1}', AdjustmentDes = '{2}' WHERE AdjustmentId = {0}", id, type, name);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAdjustment(int id)
        {
            string query = string.Format("Delete dbo.Adjustment WHERE AdjustmentId = {0}", id);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
