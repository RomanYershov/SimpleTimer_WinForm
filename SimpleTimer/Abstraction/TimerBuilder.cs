using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer.Core.Abstraction;
using Timer.Core.TimerModel;

namespace SimpleTimer.Abstraction
{
   public abstract class TimerBuilder
    {
        public MyTimer MyTimer { get; set; }
        public GroupBox Box { get; set; }
        private Form1 _myForm;
        
        

        public TimerBuilder(Form1 myForm, IExecutable func)
        {
            MyTimer = new MyTimer(func);
            _myForm = myForm;
            SetGroupBox();
        }

        private void SetGroupBox()
        {
            Box = new GroupBox();
            Box.Name = "TimerBox";
            Box.Text = "Timer";
            Box.Width = 440;
            Box.Height = 100;
            Box.Location = new Point(12, 140);
            Box.BackColor = Color.AliceBlue;
            _myForm.Controls.Add(Box);
        }
        public abstract void Build();
    }
}
