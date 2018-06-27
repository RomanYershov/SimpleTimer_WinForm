using SimpleTimer.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer.Core.Abstraction;

namespace SimpleTimer.Models
{
    public class IntervalTimerBuilder : TimerBuilder
    {
        private TextBox _textBoxShowTime;
        
        public IntervalTimerBuilder(Form1 myForm, IExecutable func) : base(myForm,func)
        {
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
            MyTimer.Start(100);
        }
    }
}
