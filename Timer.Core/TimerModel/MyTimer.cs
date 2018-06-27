using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer.Core.Abstraction;

namespace Timer.Core.TimerModel
{
    public class MyTimer : TimerBase
    {
        public MyTimer(IExecutable func) : base(func) { }
    }
}
