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
        private TextBox _textBox;
        private int _interval;
        private int count = 0;

        public IntervalTimer(TextBox textBox)
        {
            _textBox = textBox;
            _interval = 60;
        }
        public IntervalTimer(TextBox textBox, int interval)
        {
            _textBox = textBox;
            _interval = interval;
        }
        public void Execute(object obj)
        {
            _textBox.BeginInvoke((MethodInvoker)(Test));
            _textBox.ForeColor = Color.Black;
        }

        private void Test()
        {
            _textBox.Text = (++count).ToString();
            if (count % _interval == 0)
            {
                _textBox.ForeColor = Color.Red;
                Console.Beep(3000, 100);
            }

        }

    }
}
