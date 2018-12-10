using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace BRIGHTSIDE_IDEA_POS.Crystal_report
{
    public partial class Crystal_risLog : Form
    {
        private string reqby;
        private string issueby;
        private string recby;

        public Crystal_risLog(string text1, string text2, string text3)
        {
            InitializeComponent();
            reqby = text1;
            issueby = text2;
            recby = text3;
        }

        private void Crystal_risLog_Load(object sender, EventArgs e)
        {
            RisTransactionLogs ob = new RisTransactionLogs();
            

            ob.SetParameterValue("requestedby", reqby);
            ob.SetParameterValue("issuedby", issueby);
            ob.SetParameterValue("receivedby", recby);

            crystalReportViewer1.ReportSource = ob;           

            crystalReportViewer1.Refresh();
        }
    }
}
