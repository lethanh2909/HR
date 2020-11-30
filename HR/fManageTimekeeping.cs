using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using HR.DAO;
using HR.DTO;

namespace HR
{
    public partial class fManageTimekeeping : Office2007Form
    {
        BindingSource Timekeeping = new BindingSource();

        public fManageTimekeeping()
        {
            InitializeComponent();
            dtgvTimekeeping.DataSource = Timekeeping;
            loadTimekeeping();
            AddDataBinding();
        }

        void loadTimekeeping()
        {
            Timekeeping.DataSource = TimekeepingDAO.Instance.GetTableTimekeeping();
            dtgvTimekeeping.Columns[0].Visible = false;
            
        }

        void AddDataBinding()
        {
            txbClockIn.DataBindings.Add(new Binding("Text", dtgvTimekeeping.DataSource, "ClockIn", true, DataSourceUpdateMode.Never));
            txbClockOut.DataBindings.Add(new Binding("Text", dtgvTimekeeping.DataSource, "ClockOut", true, DataSourceUpdateMode.Never));
            txbAbsence.DataBindings.Add(new Binding("Text", dtgvTimekeeping.DataSource, "AbsenceTypes", true, DataSourceUpdateMode.Never));            
        }

        void FilterDtgv()
        {
            RadioButton radioBtn = this.panel3.Controls.OfType<RadioButton>()
                                           .Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                string rowFilter = string.Empty;                
                switch (radioBtn.Name)
                {
                    case "rbNoIn":
                        {
                            rowFilter += "ClockIn Is Null And ClockOut IS NOT NULL";
                        }
                        break;

                    case "rbNoOut":
                        {
                            rowFilter += "ClockOut Is Null And ClockIn IS NOT NULL";
                        }
                        break;

                    case "rbNoInOut":
                        {
                            rowFilter += "ClockOut Is Null And ClockIn IS Null And AbsenceTypes IS NULL";
                        }
                        break;

                    case "rbAbsent":
                        {
                            rowFilter += "ClockOut Is Null And ClockIn IS Null And AbsenceTypes IS NOT NULL";
                        }
                        break;

                    case "rbAll":
                        {
                            rowFilter += "";
                        }
                        break;
                }
                try
                {
                    //Check an see what's in the dgv
                    string StartDate = DatePickerFrom.Text;
                    DateTime datefrom = DateTime.ParseExact(StartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string DateFrom = datefrom.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                    string EndDate = DatePickerTo.Text;
                    DateTime dateto = DateTime.ParseExact(EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string DateTo = dateto.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                    DataTable dt = TimekeepingDAO.Instance.FilteredTimekeepingByDate(DateFrom, DateTo);

                    DataView dv = new DataView(dt);
                    dv.RowFilter = rowFilter;
                    Timekeeping.DataSource = dv;

                }
                catch (Exception)
                {
                    MessageBox.Show("Can’t find!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }        
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FilterDtgv();                        
        }       
        
        private void btnSave_Click(object sender, EventArgs e)
        {            
            if(ValidateChildren(ValidationConstraints.Enabled))
            {                
                if (DialogResult.Yes == MessageBox.Show("Do you want to save the changes?", "Message", MessageBoxButtons.YesNo))
                {
                    
                    if (txbClockIn.Text == "")
                    {
                        txbClockIn.Text = "NULL";
                    }                        
                    else
                    {
                        txbClockIn.Text = "'" + txbClockIn.Text + "'";
                    }
                    string clockin = txbClockIn.Text;

                    if (txbClockOut.Text == "")
                    {
                        txbClockOut.Text = "NULL";
                    }
                    else
                    {
                        txbClockOut.Text = "'" + txbClockOut.Text + "'";
                    }
                    string clockout = txbClockOut.Text;

                    if (txbAbsence.Text == "")
                    {
                        txbAbsence.Text = "NULL";
                    }
                    else
                    {
                        txbAbsence.Text = "'" + txbAbsence.Text + "'";
                    }
                    string absence = txbAbsence.Text;
                    int tkid = Convert.ToInt32(dtgvTimekeeping.Rows[dtgvTimekeeping.CurrentRow.Index].Cells[0].Value);

                    TimekeepingDAO.Instance.UpdateTimekeeping(tkid, clockin, clockout, absence);
                    FilterDtgv();
                }
                
            }
        }

        private void txbClockOut_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rTime = new System.Text.RegularExpressions.Regex(@"[0-2][0-9]\:[0-6][0-9]\:[0-6][0-9]");
            if (txbClockOut.Text.Length > 0)
            {
                if (!rTime.IsMatch(txbClockOut.Text))
                {
                    MessageBox.Show("Please insert the time in the right format (hh:mm:ss)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
            }
        }

        private void txbClockIn_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rTime = new System.Text.RegularExpressions.Regex(@"[0-2][0-9]\:[0-6][0-9]\:[0-6][0-9]");
            if (txbClockIn.Text.Length > 0)
            {
                if (!rTime.IsMatch(txbClockIn.Text))
                {
                    MessageBox.Show("Please insert the time in the right format (hh:mm:ss)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
            }
        }

        private void dtgvTimekeeping_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow row in dtgvTimekeeping.Rows)
            {                
                if (Convert.ToString(row.Cells[6].Value) == "" && Convert.ToString(row.Cells[8].Value) == "" && Convert.ToString(row.Cells[9].Value) == "")
                {
                    row.DefaultCellStyle.BackColor = Color.Thistle;
                }
                else if (Convert.ToString(row.Cells[9].Value) != "")
                {
                    row.DefaultCellStyle.BackColor = Color.Salmon;
                }
                else if(Convert.ToString(row.Cells[6].Value) == "")
                {
                    row.DefaultCellStyle.BackColor = Color.Khaki;
                }
                else if (Convert.ToString(row.Cells[8].Value) == "")
                {
                    row.DefaultCellStyle.BackColor = Color.PeachPuff;
                }
            }                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = 2020;
            int month = 11;            
            int days = DateTime.DaysInMonth(year, month);
            for (int i = 1; i <= days; i++)
            {
                DateTime day = new DateTime(year, month, i);
                if (day.DayOfWeek == DayOfWeek.Sunday)
                {
                    string Status ="Sunday";
                    String workday = year + "-" + month + "-" + i;

                    TimekeepingDAO.Instance.SetSunday(Status, workday);                    
                }
            }
            
        }
    }
}
