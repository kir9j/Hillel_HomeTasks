﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseEngine dataBaseEngine = new DatabaseEngine();
            dataBaseEngine.WriteValue(100, PasswordGenerator.Generate());

        }
    }
}
