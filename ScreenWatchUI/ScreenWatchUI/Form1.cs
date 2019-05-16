using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenWatchUI
{
    public partial class Form1 : Form
    {
        Timer timer;
        Stopwatch watch;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = (5000);
            timer.Tick += new EventHandler(timer_Tick);
            watch = new Stopwatch();
            timer.Start();
            watch.Start();


            //System.Threading.Thread.Sleep(5000); // time in ms
            //

            //labelElapsed.Text = elapsedTime;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = watch.Elapsed;
            string elapsedTime = String.Format("{0:00}h {1:00}m {2:00}s", ts.Hours, ts.Minutes, ts.Seconds);

            labelElapsed.Text = elapsedTime;

            //labelElapsed.Text = watch.Elapsed.Hours.ToString() + watch.Elapsed.Minutes.ToString() + watch.Elapsed.Seconds.ToString();
            SendKeys.SendWait("{NUMLOCK}");

            Application.DoEvents();
        }
    }
}
