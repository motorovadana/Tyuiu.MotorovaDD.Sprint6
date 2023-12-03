﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MotorovaDD.Sprint6.Task0.V25.Lib
{
    public class DataService : ISprint6Task0V25
    {
        public double Calculate(int x)
        {
           
            double res = (Math.Exp(x) / Math.Sqrt(Math.Pow(x, 2)));
            return Math.Round(res, 3);
        }


    }
}
