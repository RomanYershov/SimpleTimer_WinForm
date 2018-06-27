using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer.Core.Abstraction;

namespace SimpleTimer.ExecuteMethods
{
    class WorkRelaxIntervalTimer : IExecutable
    {
        public int Count { get; set; }
        private bool isRelax;
        private int _workTime;
        private int _relaxTime;
        public int WorkTime
        {
            get
            {
                return _workTime;
            }
            private set
            {
                _workTime = value * 60;
            }
        }
        public int RelaxTime
        {
            get
            {
                return _relaxTime;
            }
            private set
            {
                _relaxTime = value * 60;
            }
        }

        public List<Control> Controls { get; set; }

        public WorkRelaxIntervalTimer(int workTime, int relaxTime)
        {
            Controls = new List<Control>();
            WorkTime = workTime;
            RelaxTime = relaxTime;
        }

        public void Execute(object obj)
        {
            Console.WriteLine(++Count);

            if (isRelax)
            {
                StartWork();
            }
            else
            {
                StartRelax();
            }
        }

        private void StartRelax()
        {
            if (_workTime == 0) return;

            if (Count % _workTime == 0)
            {
                isRelax = true;
                Count = 0;
                Console.Beep(2000, 100);
                Console.Beep(4020, 100);
                Console.Beep(5020, 100);
                Console.Beep(6020, 100);
                Console.Beep(6700, 100);
            }

        }

        private void StartWork()
        {
            if (_relaxTime == 0) return;

            if (Count % _relaxTime == 0)
            {
                isRelax = false;
                Count = 0;
                Console.Beep(6700, 100);
                Console.Beep(6020, 100);
                Console.Beep(5020, 100);
                Console.Beep(4020, 100);
                Console.Beep(2000, 100);
            }
        }
    }
}

