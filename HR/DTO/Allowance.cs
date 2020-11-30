using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class Allowance
    {
        public Allowance(int AllId, string AllName, int AllTax, int Amount, string AllFormulaName, string AllFormula, int Result)
        {
            this.AllId = AllId;
            this.AllName = AllName;
            this.AllTax = AllTax;
            this.Amount = Amount;
            this.AllFormula = AllFormula;
            this.AllFormulaName = AllFormulaName;
            this.Result = Result;
        }

        public Allowance(DataRow row)
        {
            this.AllId = (int)row["AllId"];
            this.AllName = row["AllName"].ToString();
            this.AllTax = (int)row["AllTax"];
            this.Amount = (int)row["Amount"];
            this.AllFormulaName = row["AllFormulaName"].ToString();
            this.AllFormula = row["AllFormula"].ToString();
            this.Result = (int)row["Result"];
        }

        private int allId;

        public int AllId
        {
            get { return allId; }
            set { allId = value; }
        }

        private string allName;

        public string AllName
        {
            get { return allName; }
            set { allName = value; }
        }

        private int allTax;

        public int AllTax
        {
            get { return allTax; }
            set { allTax = value; }
        }

        private int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private string allFormulaName;

        public string AllFormulaName
        {
            get { return allFormulaName; }
            set { allFormulaName = value; }
        }

        private string allFormula;

        public string AllFormula
        {
            get { return allFormula; }
            set { allFormula = value; }
        }

        private int result;

        public int Result
        {
            get { return result; }
            set { result = value; }
        }

    }
}

