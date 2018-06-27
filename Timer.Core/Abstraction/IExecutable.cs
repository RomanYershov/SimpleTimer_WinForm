using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer.Core.Abstraction
{
    public interface IExecutable
    {
        List<Control> Controls { get; set; }

        void Execute(object obj);
    }
}
