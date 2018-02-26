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
    public partial class printReceipt : Form
    {

        
        private string name;
        private string datetime;
        private string invoiceid;


        public printReceipt(string text1, string text2, string text3)
        {

            InitializeComponent();
            name = text1;
            datetime = text2;
            invoiceid = text3;
           
        }

        

        private void printReceipt_Load(object sender, EventArgs e)
        {
            printMe ob = new printMe();
            ob.SetParameterValue("cashier", name);
            ob.SetParameterValue("date", datetime);
            ob.SetParameterValue("invoice", invoiceid);
           

            
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }
    }
}
