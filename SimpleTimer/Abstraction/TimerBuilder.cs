using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Timer.Core.Abstraction;
using Timer.Core.TimerModel;

namespace SimpleTimer.Abstraction
{
   public abstract class TimerBuilder
    {
        public MyTimer MyTimer { get; set; }
        public GroupBox Box { get; set; }
        private Form _myForm;
        
        

        public TimerBuilder(Form myForm, IExecutable func)
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
            Box.Controls.Add(CreateCloseTimerBtn());
            _myForm.Controls.Add(Box);           
        }

        private Button CreateCloseTimerBtn()
        {
            Button btnClose = new Button
            {
                Text = "X",
                Width = 24,
                Height = 24,
                Name = "btnClose",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(558,13)
            };
            return btnClose;
        }
        public abstract void Build();
    }
}
