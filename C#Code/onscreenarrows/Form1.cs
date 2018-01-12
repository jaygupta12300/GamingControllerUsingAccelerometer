using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace onscreenarrows
{
    public partial class Form1 : Form
    {
        private SerialPort myport;
        private string indata;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle = 0x08000000;
                return param;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            try {
                myport = new SerialPort();
                myport.BaudRate = 9600;
                myport.PortName = "COM4";
                myport.Open();
                while (true)
                {
                    indata = myport.ReadLine();
                    string[] str1 = indata.Split(' ');
                    int x = Int32.Parse(str1[0]);
                    int y = Int32.Parse(str1[1]);
                    if (x < 350)
                    {
                        SendKeys.SendWait("{LEFT}");
                    }
                    else if (x > 400)
                    {
                        SendKeys.SendWait("{RIGHT}");
                    }
                    else { }
                    if (y < 350)
                    {
                        SendKeys.SendWait("{DOWN}");
                    }
                    else if (y > 400)
                    {
                        SendKeys.SendWait("{SPACE}");
                    }
                    else { }
                }
            }
            finally
            {
                myport.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myport.Close();
        }
    }
}
