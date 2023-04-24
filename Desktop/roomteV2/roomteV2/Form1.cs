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
using System.IO.Ports;

namespace roomteV2
{
    public partial class Form1 : Form
    {
        
        SerialPort port;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            port = new SerialPort("COM9", 9600);
            try
            {
                port.Open();
                setup();
            }
            catch
            {
                throw new System.Exception("Port konnte nicht geöffnet werden.");
            }
        }

        private void setup()
        {
            int delay = 2550;
            System.Threading.Thread.Sleep(delay);
            port.Write("10"); //Esstisch aus
            System.Threading.Thread.Sleep(delay);
            port.Write("11"); //Esstisch an
            System.Threading.Thread.Sleep(delay);
            port.Write("20"); //BarLicht aus
            System.Threading.Thread.Sleep(delay);
            port.Write("21"); //BarLicht an
            System.Threading.Thread.Sleep(delay);
            port.Write("30"); //rolladen runter
            System.Threading.Thread.Sleep(delay);
            port.Write("31"); //rolladeb hoch
            System.Threading.Thread.Sleep(delay);
            port.Write("55"); //Dummy
            System.Threading.Thread.Sleep(delay);
            port.Write("55"); //Dummy
        }


        private void btn_an_Click(object sender, EventArgs e)
        {
            port.Write("11");
        }

        private void btn_aus_Click(object sender, EventArgs e)
        {
            port.Write("10");
        }

       private void btn_barAn_Click_1(object sender, EventArgs e)
        {
            port.Write("21");
        }

       private void btn_barAus_Click(object sender, EventArgs e)
       {
           port.Write("20");
       }

       private void btn_rolladenHoch_Click(object sender, EventArgs e)
       {
           port.Write("31");
       }

       private void btn_rolladenRunter_Click(object sender, EventArgs e)
       {
           port.Write("30");

       }

       private void btn_setup_Click(object sender, EventArgs e)
       {
           setup();
       }
    }
}