using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class Employee
    {
        public Employee(string EmpId, string Image, string FirstName, string LastName , string Email, string Gender, string Address, string City , string State , DateTime Dob , string Nationality, string Maritalstatus, string Phone, string Highschool, string University, string College, string Religion, string DepaName, string PosiName, int PosiId)
        {
            this.EmpId = EmpId;
            this.Image = Image;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Gender = Gender;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Dob = Dob;
            this.Nationality = Nationality;
            this.Maritalstatus = Maritalstatus;
            this.Phone = Phone;
            this.Highschool = Highschool;
            this.University = University;
            this.College = College;
            this.Religion = Religion;
            this.DepaName = DepaName;
            this.PosiName = PosiName;
            this.PosiId = PosiId;
        }

        public Employee(DataRow row)
        {
            this.EmpId = (string)row["EmpId"];
            this.Image = row["Image"].ToString();
            this.FirstName = (string)row["FirstName"];
            this.LastName = (string)row["LastName"];
            this.Email = row["Email"].ToString();
            this.Gender = (string)row["Gender"];
            this.Address = (string)row["Address"];
            this.City = row["City"].ToString();
            this.State = row["State"].ToString();
            this.Dob = (DateTime)row["Dob"];
            this.Nationality = row["Nationality"].ToString();
            this.Maritalstatus = row["Maritalstatus"].ToString();
            this.Phone = (string)row["Phone"];
            this.Highschool = row["Highschool"].ToString();
            this.University = row["University"].ToString();
            this.College = row["College"].ToString();
            this.Religion = row["Religion"].ToString();
            this.DepaName = row["DepaName"].ToString();
            this.PosiName = row["PosiName"].ToString();
            this.PosiId = (int)row["PosiId"];
        }        

        private string empId;

        public string EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
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

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        private DateTime dob;

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        private string nationality;

        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }

        private string maritalstatus;

        public string Maritalstatus
        {
            get { return maritalstatus; }
            set { maritalstatus = value; }
        }

        private string religion;

        public string Religion
        {
            get { return religion; }
            set { religion = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string highschool;

        public string Highschool
        {
            get { return highschool; }
            set { highschool = value; }
        }

        private string university;

        public string University
        {
            get { return university; }
            set { university = value; }
        }

        private string college;

        public string College
        {
            get { return college; }
            set { college = value; }
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

        private int posiId;

        public int PosiId
        {
            get { return posiId; }
            set { posiId = value; }
        }






    }
}
