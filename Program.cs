﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            m.SeleccionOpc();
            Console.Read();
        }
    }
}
