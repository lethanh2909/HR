using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class SalaryFormula
    {
        public SalaryFormula(int SformulaId, string SformulaName, string Sformula)
        {
            this.SformulaId = SformulaId;
            this.SformulaName = SformulaName;
            this.Sformula = Sformula;
        }

        public SalaryFormula(DataRow row)
        {
            this.SformulaId = (int)row["SformulaId"];
            this.SformulaName = row["SformulaName"].ToString();
            this.Sformula = row["Sformula"].ToString(); ;

        }

        private int formulaId;

        public int SformulaId
        {
            get { return formulaId; }
            set { formulaId = value; }
        }

        private string formulaName;

        public string SformulaName
        {
            get { return formulaName; }
            set { formulaName = value; }
        }

        private string formula;

        public string Sformula
        {
            get { return formula; }
            set { formula = value; }
        }
    }
}
