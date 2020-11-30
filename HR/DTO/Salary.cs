using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class Salary
    {
        public Salary(int SalId, string EmpId, string FirstName, string LastName, string DepaName, string PosiName, int SalBase, string AllType,  int Allamount, string SalFomula, int AllowanceId)
        {           
            this.SalId = SalId;
            this.EmpId = EmpId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DepaName = DepaName;
            this.PosiName = PosiName;
            this.SalBase = SalBase;
            this.AllType = AllType;
            this.AllowanceId = AllowanceId;
            this.SalFomula = SalFomula;
        }

        public Salary(DataRow row)
        {
            this.SalId = (int)row["SalId"];
            this.EmpId = (string)row["EmpId"];
            this.FirstName = (string)row["FirstName"];
            this.LastName = (string)row["LastName"];
            this.DepaName = (string)row["DepaName"];
            this.PosiName = (string)row["PosiName"];
            this.SalBase = (int)row["SalBase"];
            this.AllType = (string)row["AllType"];
            this.AllowanceId = (int)row["AllowanceId"];
            this.SalFomula = (string)row["SalFomula"];
        }

        private int salId;

        public int SalId
        {
            get { return salId; }
            set { salId = value; }
        }

        private string empId;

        public string EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string depaName;

        public string DepaName
        {
            get { return depaName; }
            set { depaName = value; }
        }

        private string posiName;

        public string PosiName
        {
            get { return posiName; }
            set { posiName = value; }
        }

        private int salBase;

        public int SalBase
        {
            get { return salBase; }
            set { salBase = value; }
        }

        private string allType;

        public string AllType
        {
            get { return allType; }
            set { allType = value; }
        }

        private int allowanceId;

        public int AllowanceId
        {
            get { return allowanceId; }
            set { allowanceId = value; }
        }

        private string salFomula;

        public string SalFomula
        {
            get { return salFomula; }
            set { salFomula = value; }
        }


    }
}
