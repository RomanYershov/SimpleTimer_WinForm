using SimpleTimer.ExecuteMethods;
using SimpleTimer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Timer.Core.TimerModel;

namespace SimpleTimer
{
    public partial class Form1 : Form
    {
        MyTimer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // timer = new MyTimer(new IntervalTimer(textBoxShow,int.Parse(textBoxInterval.Text)));
            WorkRelaxTimerBuilder timerBuilder = new WorkRelaxTimerBuilder(this ,new WorkRelaxIntervalTimer(1, 2));
            timerBuilder.Build();

            //timer = new MyTimer(new WorkRelaxIntervalTimer(1, 2));
            //timer.Start(100);
        }


        private void btn_reset_Click(object sender, EventArgs e)
        {
         if (timer == null) return;
            timer.Reset();
            textBoxShow.Text = "0";
        }
    }


}
