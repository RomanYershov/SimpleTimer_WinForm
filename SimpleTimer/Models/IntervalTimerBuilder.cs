using SimpleTimer.Abstraction;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer.Core.Abstraction;

namespace SimpleTimer.Models
{
    public class IntervalTimerBuilder : TimerBuilder
    {
        //private TextBox _textBoxShowTime;

        public IntervalTimerBuilder(Form1 myForm, IExecutable func) : base(myForm, func)
        {
            var showTb = func.Controls.FirstOrDefault(t => t.Name.Contains("showTB"));
            var setIntervalTb = func.Controls.FirstOrDefault(t => t.Name.Contains("setIntervalTB"));

            if (showTb == null || setIntervalTb == null) return;

            showTb.Location = new Point(60, 60);
            setIntervalTb.Location = new Point(200, 60);
            Box.Controls.AddRange(new Control[] { showTb, setIntervalTb });
        }

        public override void Build()
        {
            Box.Controls.Add(CreateButtonStart());
        }

        private Button CreateButtonStart()
        {
            Button btnStart = new Button
            {
                Text = "Start",
                ForeColor = System.Drawing.Color.IndianRed
            };
            btnStart.Click += BtnStartClick;
            return btnStart;
        }

        private void BtnStartClick(object sender, EventArgs e)
        {
            MyTimer.Start(1000);
        }
    }
}
