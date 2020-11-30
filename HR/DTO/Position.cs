using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class Position
    {
        public Position(int id, string name, int deid)
        {
            this.ID = id;
            this.PositionName = name;
            this.DeId = deid;
        }

        public Position(DataRow row)
        {
            this.ID = (int)row["PosId"];
            this.PositionName = row["PosName"].ToString();
            this.DeId = (int)row["DeId"];
        }

        private string positionname;

        public string PositionName
        {
            get { return positionname; }
            set { positionname = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private int deId;

        public int DeId
        {
            get { return deId; }
            set { deId = value; }
        }
    }
}
