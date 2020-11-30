using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class AllowanceSummary
    {
        public AllowanceSummary(int asid, string Empid, string Fullname, string AllowanceType, int AllowanceAmount, string AllFormula, int Month, int Year)
        {
            this.asid = asid;
            this.Empid = Empid;
            this.Fullname = Fullname;
            this.AllowanceType = this.AllowanceType;
            this.AllowanceAmount = this.AllowanceAmount;
            this.AllFormula = AllFormula;            
            this.Month = Month;
            this.Year = Year;

        }

        public AllowanceSummary(DataRow row)
        {
            this.asid = (int)row["asid"];
            this.Empid = row["EmpId"].ToString();
            this.Fullname = row["Fullname"].ToString();
            this.AllowanceType = row["AllowanceType"].ToString();
            this.AllowanceAmount = (int)row["AllowanceAmount"];
            this.AllFormula = row["AllFormula"].ToString();
            this.Month = (int)row["Month"];
            this.Year = (int)row["Year"];
        }

        private int Asid;

        public int asid
        {
            get { return Asid; }
            set { Asid = value; }
        }

        private string empid;

        public string Empid
        {
            get { return empid; }
            set { empid = value; }
        }

        private string fullname;

        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }

        private string allowanceType;

        public string AllowanceType
        {
            get { return allowanceType; }
            set { allowanceType = value; }
        }

        private int allowanceAmount;

        public int AllowanceAmount
        {
            get { return allowanceAmount; }
            set { allowanceAmount = value; }
        }

        private string allFormula;

        public string AllFormula 
        {
            get { return allFormula; }
            set { allFormula = value; }
        }

        private int month;

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
    }
}
