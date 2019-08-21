using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Class1
    {
        private double a, b, c;

        public void SetABC(double termo1, double termo2, double termo3)
        {
            a = termo1;
            b = termo2;
            c = termo3;
        }
        public void GetABC(out double termo1, out double termo2, out double termo3)
        {
            termo1 = a;
            termo2 = b;
            termo3 = c;
        }
        public bool RaizesReais()
        {
            if (Delta() >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double Delta()
        {
            return b * b - 4 * a * c;
        }
        public bool X1(out double x)
        {
            x = 0;
            if (RaizesReais() == false || a == 0)
            {
                return false;
            }
            else
            {
                x = (-b + Math.Sqrt(Delta())) / 2 * a;
                return true;
            }
        }
        public bool X2(out double x)
        {
            x = 0;
            if (RaizesReais() == false || a == 0)
            {
                return false;
            }
            else
            {
                x = (-b + Math.Sqrt(Delta())) / 2 * a;
                return true;
            }
        }
    }
}

