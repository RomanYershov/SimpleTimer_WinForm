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
   public abstract class TimerBuilder : IDisposable
    {
        protected MyTimer MyTimer { get; set; }
        protected GroupBox Box { get; set; }
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
            Box.BackColor = Color.CadetBlue;
            Box.Controls.Add(CreateCloseTimerBtn());           
            _myForm.Controls.Add(Box);           
        }

        private Button CreateCloseTimerBtn()
        {
            Button btnClose = new Button
            {
                Text = "X",
                Width = 22,
                Height = 22,
                Name = "btnClose",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(418, 5)
            };
            btnClose.Click += BtnCloseClick;
            return btnClose;
        }

        private void BtnCloseClick(object sender, EventArgs e)
        {
            Box.Dispose();
            MyTimer.Reset();
        }
        public abstract void Build();

        public void Dispose()
        {
            ////Box.Dispose();
            //MyTimer.Reset();
        }
    }
}
