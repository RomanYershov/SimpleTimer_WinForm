using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer.Core.Abstraction
{
    public interface IExecutable
    {
        void Execute(object obj);
    }
}
