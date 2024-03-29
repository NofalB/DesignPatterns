﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public abstract class BigDataLoader
    {
        public void EtlProcess()
        {
            Start();
            Extract();
            Transform();
            Load();
            End();
        }

        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[ETL-process started]");
            Console.ResetColor();
        }
        public abstract void Extract();
        public abstract void Transform();
        public abstract void Load();
        public void End()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[ETL-process finished]");
            Console.WriteLine("\n");
            Console.ResetColor();
        }

    }
}
