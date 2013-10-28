using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лабораторная_работа__5
{
    class Program
    {
        static void Main(string[] args)
        {
            DRV[] drv = new DRV[2];
            drv[0] = new Proxy("1", 1);
            //drv[0] = new DRV1("1"); 
            //drv[0].Solver();
            drv[1] = new Proxy("2", 2);            
            //drv[1] = new DRV2("2");
            //drv[1].Solver();
            for (int i = 0; i < drv.Length; i++)
                drv[i].Solver();
            Console.WriteLine("Патерн - адаптер");
            System.Threading.Thread.Sleep(2000);
            Args arg = new Args();
            arg.a = 10;
            arg.b = 30;
            MyTask[] ps = new MyTask[2];
            ps[1] = new ProTask();
            Console.WriteLine(ps[1].Solver(arg));
        }
    }
}
