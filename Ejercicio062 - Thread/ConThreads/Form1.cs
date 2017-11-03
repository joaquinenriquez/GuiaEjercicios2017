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

namespace ConThreads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(actualizarLabel);
            t.Start();
        }

        public void actualizarLabel()
        {
            while (true)
            {
                if (label1.InvokeRequired)
                {
                    label1.BeginInvoke((MethodInvoker)delegate()
                    {
                        label1.Text = DateTime.Now.ToString();
                        
                    }
                );
                }
                else
                {
                    label1.Text = DateTime.Now.ToString();
                }
                
                Thread.Sleep(1000);

            }
        }
    }
}

