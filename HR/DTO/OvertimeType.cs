using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class OvertimeType
    {
        public OvertimeType(int Typeid, string OvertimeType, int OvertimeValue)
        {
            this.Typeid = Typeid;
            this.Overtimetype = OvertimeType;
            this.OvertimeValue = OvertimeValue;            
        }

        public OvertimeType(DataRow row)
        {
            this.Typeid = (int)row["Typeid"];
            this.Overtimetype = row["OvertimeType"].ToString();
            this.OvertimeValue = (int)row["Value"];            
        }

        private int typeid;

        public int Typeid
        {
            get { return typeid; }
            set { typeid = value; }
        }

        private string overtimeType;

        public string Overtimetype
        {
            get { return overtimeType; }
            set { overtimeType = value; }
        }

        private int valu;

        public int OvertimeValue
        {
            get { return valu; }
            set { valu = value; }
        }
    } 
}
