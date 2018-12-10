using BRIGHTSIDE_IDEA_POS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ReportTodaysLog : Form
    {

        private double tlog;
        public ReportTodaysLog(double totalrmed)
        {
            InitializeComponent();
            tlog = totalrmed;
        }

    

         private void ReportTodaysLog_Load(object sender, EventArgs e)
        {
            TodaysLog ob = new TodaysLog();
            ob.SetParameterValue("totalval1", tlog);

            cashiers_log.ReportSource = ob;
            cashiers_log.Refresh();
        }
    }
}
