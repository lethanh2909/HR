using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class AllowanceFormula
    {
        public AllowanceFormula(int FormulaId, string FormulaName, string Formula)
        {
            this.FormulaId = FormulaId;
            this.FormulaName = FormulaName;
            this.Formula = Formula;
        }

        public AllowanceFormula(DataRow row)
        {
            this.FormulaId = (int)row["FormulaId"];
            this.FormulaName = row["FormulaName"].ToString();
            this.Formula = row["Formula"].ToString(); ;
            
        }

        private int formulaId;

        public int FormulaId
        {
            get { return formulaId; }
            set { formulaId = value; }
        }

        private string formulaName;

        public string FormulaName
        {
            get { return formulaName; }
            set { formulaName = value; }
        }

        private string formula;

        public string Formula
        {
            get { return formula; }
            set { formula = value; }
        }
    }        
}
