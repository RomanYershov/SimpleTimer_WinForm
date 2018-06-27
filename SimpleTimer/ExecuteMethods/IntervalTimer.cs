using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer.Core.Abstraction;

namespace SimpleTimer.ExecuteMethods
{
    class IntervalTimer : IExecutable
    {

        private int _interval;
        private int count = 0;
        public List<Control> Controls { get; set; }

        public IntervalTimer()
        {
            Controls = new List<Control>
            {
                new TextBox()  {  Name = "showTB"},
                new TextBox(){Name = "setIntervalTB"}
            };
             
            _interval = int.Parse(Controls[1].Text);
        }
        public IntervalTimer(int interval)
        {
            Controls = new List<Control>
            {
                new TextBox()  {  Name = "showTB"},
                new TextBox(){Name = "setIntervalTB"}
            };

            _interval  = string.IsNullOrEmpty(Controls[1].Text)? 2 : int.Parse(Controls[1].Text);
        }




        public void Execute(object obj)
        {
            var tb = Controls.FirstOrDefault(t => t.Name.Contains("showTB"));
            tb.BeginInvoke((MethodInvoker)(StartTimer));
            tb.ForeColor = Color.Black;
        }

        private void StartTimer()
        {
            var tb = Controls.FirstOrDefault(t => t.Name.Contains("showTB"));
            tb.Text = (++count).ToString();
            if (count % _interval == 0)
            {
                tb.ForeColor = Color.Red;
                Console.Beep(3000, 100);
            }

        }

    }
}
