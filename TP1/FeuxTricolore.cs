using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TP1
{
    public partial class FeuxTricolore : Form
    {
        public Thread t;
        public bool OK = true;
        public AutoResetEvent Restart;


        public FeuxTricolore()
        {
            InitializeComponent();
            t = new Thread(CodeThread);
            Restart = new AutoResetEvent(false);
            t.Start();
        }
        void CodeThread()
        {
            
            while (OK)
            {
                
                Restart.WaitOne();

                FOrange.BackColor = Color.Black;
                FRouge.BackColor = Color.Black;
                FVert.BackColor = Color.Green;

                Thread.Sleep(1000);

                FOrange.BackColor = Color.Orange;
                FRouge.BackColor = Color.Black;
                FVert.BackColor = Color.Black;

                Thread.Sleep(1000);

                FOrange.BackColor = Color.Black;
                FRouge.BackColor = Color.Red;
                FVert.BackColor = Color.Black;

                Thread.Sleep(1000);

                FOrange.BackColor = Color.Black;
                FRouge.BackColor = Color.Black;
                FVert.BackColor = Color.Green;

            }
        }

        private void bAppel_Click(object sender, EventArgs e)
        {
            Restart.Set();
        }
    }
}
