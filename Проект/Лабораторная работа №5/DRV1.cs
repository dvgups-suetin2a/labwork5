﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Лабораторная_работа__5
{
    class DRV1:DRV
    {
        public DRV1(string name)
        {
            Name = name;
            Console.WriteLine("Начало загрузки " + Name);
            Thread.Sleep(3000);
            Console.WriteLine("Завершение загрузки " + Name);
        }
        public override void Solver()
        {
            Console.WriteLine("Работа устройства " + Name);
        }
    }
}
