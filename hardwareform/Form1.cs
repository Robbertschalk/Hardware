using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace hardwareform
{
    public partial class Form1 : Form
    {

        PerformanceCounter perfcpu = new PerformanceCounter("Processor Information","% Processor Time", "_Total");


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StreamWriter File = new StreamWriter("Data.txt");
            label1.Text = "CPU:" + " " + (int)perfcpu.NextValue() + " " + "%";
            string cpu = "CPU:" + " " + (int)perfcpu.NextValue() + " " + "%";
            File.Write(cpu);
            File.Close();
                            
                                        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
