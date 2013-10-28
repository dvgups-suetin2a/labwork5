using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лабораторная_работа__5
{
    class Proxy:DRV
    {
        DRV drv=null;
        int type;
        public Proxy(string N, int type)
        {
            Name = N;
            this.type = type;
        }
        public override void Solver()
        {
            if (drv == null)
                drv = Create();
            drv.Solver();
        }
        public DRV Create()
        {
            switch (type)
            {
                case 1:
                    return new DRV1(Name);
                case 2:
                    return new DRV2(Name);
                default:
                    return null;
            }

        }
    }
}
