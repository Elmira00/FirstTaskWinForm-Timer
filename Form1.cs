using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstTaskWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
           BakuBtn.Font= new Font("Arial", 10, FontStyle.Regular);
           LondonBtn.Font= new Font("Arial", 10, FontStyle.Regular);
           timeLbl.Font = new Font("Arial", 40, FontStyle.Regular);
            timeLbl.ForeColor = Color.WhiteSmoke;
            Timer = new Timer();
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }
        public Timer Timer { get; set; }
        private void Timer_Tick(object sender, EventArgs e)
        {    
            timeLbl.Text = DateTime.Now.ToLongTimeString();
        }
        private void Timer_Tick2(object sender, EventArgs e)
        {
            string text = DateTime.Now.AddHours(-4).ToLongTimeString();
            timeLbl.Text = text;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
                     
            Timer.Tick += Timer_Tick;
            this.BackgroundImage = Properties.Resources.BakuImg;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

            Timer.Tick += Timer_Tick2;
            this.BackgroundImage = Properties.Resources.LondonImg;
        }
    }
}
