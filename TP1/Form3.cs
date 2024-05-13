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
    public partial class Form3 : Form
    {
        FeuxTricolore F1, F2, F3;
        public Thread tTot;
        public bool STot = true;
        AutoResetEvent Restart;


        private void bStart_Click(object sender, EventArgs e)
        {
            
            F1 = new FeuxTricolore();
            F1.MdiParent = this;
            F1.Show();

            F2 = new FeuxTricolore();
            F2.MdiParent = this;
            F2.Show();

            F3 = new FeuxTricolore();
            F3.MdiParent = this;
            F3.Show();
            this.LayoutMdi(MdiLayout.TileVertical);

            tTot = new Thread(CodeThreadTot);
            tTot.Start();
        }
        private void bStop_Click(object sender, EventArgs e)
        {
            F1.OK = false;
            F2.OK = false;
            F3.OK = false;
        }
        private void bDestroy_Click(object sender, EventArgs e)
        {
            F1.Close();
            F2.Close();
            F3.Close();
        }
        public Form3()
        {
            InitializeComponent();
        }
        void CodeThreadTot()
        {
            while (STot)
            {
                
                F3.Restart.Set();
                Thread.Sleep(2000);
                F2.Restart.Set();
                Thread.Sleep(2000);
                F1.Restart.Set();
                Thread.Sleep(1000);


            }
        }
    }
}
