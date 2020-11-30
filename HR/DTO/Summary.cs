using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class Summary
    {
        public Summary(int ptid, string Empid, string Fullname, int BaseSalary, int Attendance, int Absent, string SalaryFormula, int Month, int Year)
        {
            this.ptid = ptid;
            this.Empid = Empid;
            this.Fullname = Fullname;
            this.BaseSalary = BaseSalary;
            this.Attendance = Attendance;
            this.Absence = Absence;
            this.SalaryFormula = SalaryFormula;
            this.Month = Month;
            this.Year = Year;
        }

        public Summary(DataRow row)
        {
            this.ptid = (int)row["ptid"];
            this.Empid = row["EmployeeId"].ToString();
            this.Fullname = row["Fullname"].ToString();
            this.BaseSalary = (int)row["BaseSalary"];
            this.Attendance = (int)row["Attendance"];
            this.Absence = (int)row["Absence"];
            this.SalaryFormula = row["SalaryFormula"].ToString();
            this.Month = (int)row["Month"];
            this.Year = (int)row["Year"];

        }

        private int Ptid;

        public int ptid
        {
            get { return Ptid; }
            set { Ptid = value; }
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

        private int baseSalary;

        public int BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }        

        private int attendance;

        public int Attendance
        {
            get { return attendance; }
            set { attendance = value; }
        }

        private int absence;

        public int Absence
        {
            get { return absence; }
            set { absence = value; }
        }

        private string salaryFormula;

        public string SalaryFormula
        {
            get { return salaryFormula; }
            set { salaryFormula = value; }
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
