using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лабораторная_работа__5
{
    class ProTask : MyTask
    {
        public override double Solver(Args e)
        {
            return base.Solver(e.a, e.b);
        }
    }
}
