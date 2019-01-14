using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            
            InitializeComponent();

        }

     
        private void timer1_Tick(object sender, EventArgs e)
        {
            load.Width += 5;

            if (load.Width == 90)
            {
                label1.Text = "waiting...";

            }else if (load.Width == 150)
            {
                 
                label1.Text = "Completing the system requirements...";
            }
            else if (load.Width == 200)
            {
                label1.Text = "preparing login form...";
            }
            else if (load.Width == 270)
            {
                ///load.BackColor = Color.Lime;
               // bar.BackColor = Color.Yellow;
                label1.Text = "preparing Inventory UI...";
            }
            else if (load.Width == 350)
            {
                label1.Text = "preparing POS UI...";
            }
            else if (load.Width == 450)
            {
               label1.Text = "Getting Ready...";
            }
            else if (load.Width == 490)
            {
                label1.Text = "This is made by BRIGHTSIDE IDEA GROUP...";
            }
            else if (load.Width == 700)
            {
                label1.Text = "All Data is ready..";
            }
            else if (load.Width >= 800)
            {
                timer1.Stop();
                mform log = new mform();
                log.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
