using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer.Core.Abstraction
{
    public abstract class TimerBase
    {
        private IExecutable _method;
        private TimerCallback TimerCallback;
        public  System.Threading.Timer Timer;

        public TimerBase(IExecutable func)
        {
            _method = func;
            TimerCallback = new TimerCallback(_method.Execute);
        }



        public virtual void Start()
        {
            Timer = new System.Threading.Timer(TimerCallback, 0, 0, 1000);
        }

        public virtual void Start(int interval) => 
            Timer = new System.Threading.Timer(TimerCallback, 0, 0, interval);



        public void Reset()
        {
            if (Timer == null) return;
            Timer.Dispose();
        }
    }
}
