using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
                if (progressBar1.Value == 50)
                {
                    tmrTime.Enabled = false;
                }
                progressBar1.Value += 2;
            tmrTime2.Start();
        }

        private void tmrTime2_Tick(object sender, EventArgs e)
        {

            if (tmrTime.Enabled==false)
            {
                if (progressBar2.Value == 50)
                {
                    tmrTime2.Enabled = false;
                }
                progressBar2.Value += 2;
            }
            tmrTime3.Start();
        }

        private void tmrTime3_Tick(object sender, EventArgs e)
        {
            if(tmrTime2.Enabled==false)
            {
                if (progressBar3.Value == 95)
                {
                    tmrTime3.Enabled = false;
                }
                progressBar3.Value += 5;

            }
        }
    }
}
