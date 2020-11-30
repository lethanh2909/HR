using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAO
{
    public class PositionDAO
    {
        private static PositionDAO instance;

        public static PositionDAO Instance
        {
            get { if (instance == null) instance = new PositionDAO(); return PositionDAO.instance; }
            private set { PositionDAO.instance = value; }
        }

        private PositionDAO() { }


        public List<Position> GetListPositionbyDepId(int id)
        {
            List<Position> list = new List<Position>();

            string query = "select * from Position where DeId = " + id;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Position position = new Position(item);
                list.Add(position);
            }

            return list;
        }

        

        public DataTable GetTablePosition(int id)        {
            

            string query = "select * from Position where DeId = " + id;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            return data;
        }


        public Position CheckPositionyByDeID(int id)
        {
            Position position = null;

            string query = "select * from Position where DeId = " + id;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                position = new Position(item);
                return position;
            }

            return position;
        }

        public void InsertPosition(string name , int deid)
        {
            string query = string.Format("INSERT dbo.Position ( PosName, DeId ) VALUES  ( N'{0}', {1})", name, deid);
            Dataprovider.Instance.ExecuteNonQuery(query);            
        }

        public bool UpdatePosition(string name, int id)
        {
            string query = string.Format("UPDATE dbo.Position SET PosName = N'{0}' WHERE PosId = {1}", name, id);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeletePosition(int id)
        {
            string query = string.Format("Delete dbo.Position WHERE PosId = {0}", id);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
