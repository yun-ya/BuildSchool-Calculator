﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MaTH
    {
        public double Mysum(double a, double b)
        {
            return a + b;
        }
        public double MyMiner(double a, double b)
        {
            return a - b;
        }
        public double Mymultiply(double a, double b)
        {
            return a * b;
        }
        public double Mydivided(double a, double b)
        {
            if (a < b)
            {
                return 0;
            }
            else
            {
                return a / b;
            }
            
        }
        public double MyPi(double a)
        {
            return a * Math.PI;
        }
    }








}
