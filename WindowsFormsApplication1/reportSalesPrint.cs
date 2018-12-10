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
    public partial class reportSalesPrint : Form
    {
        

        public reportSalesPrint(string text)
        {
            InitializeComponent();
            Text = text;
        }

        private void reportSalesPrint_Load(object sender, EventArgs e)
        {
            SalesReport ob = new SalesReport();
            ob.SetParameterValue("total", Text);
            salesPrint.ReportSource = ob;
            salesPrint.Refresh();
        }
    }
}
