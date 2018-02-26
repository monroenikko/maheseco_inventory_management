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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
            }
            
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            //173 ,10
            


        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bclose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bminimize2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //173 ,10

           
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {

            if (paneluser.Width == 10)
            {
                
               
                paneluser.Visible = false;
                animation.ShowSync(paneluser);
                paneluser.Width = 193;
            }
            else
            {
                paneluser.Visible = false;
                animation.ShowSync(paneluser);
                paneluser.Width = 10;

            }
        }

        private void Cashier_Click(object sender, EventArgs e)
        {
            if (paneluser.Width == 193)
            {
                paneluser.Width = 10;
                paneluser.Visible = false;
                animation.ShowSync(paneluser);
            }
           
        }

        private void plbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
