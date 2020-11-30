using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{    
    public class Department
    {
        public Department(int id, string name)
        {
            this.ID = id;
            this.DepartmentName = name;
        }

        public Department(DataRow row)
        {
            this.ID = (int)row["DepId"];
            this.DepartmentName = row["DepName"].ToString();
        }

        private string name;

        public string DepartmentName
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
