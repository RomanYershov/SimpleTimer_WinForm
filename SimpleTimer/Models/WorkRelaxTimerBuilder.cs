using SimpleTimer.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer.Core.Abstraction;

namespace SimpleTimer.Models
{
    public class WorkRelaxTimerBuilder : TimerBuilder
    {
        public WorkRelaxTimerBuilder(Form1 myForm, IExecutable func) : base(myForm, func)
        {
        }

        public override void Build()
        {
           
        }
    }
}
