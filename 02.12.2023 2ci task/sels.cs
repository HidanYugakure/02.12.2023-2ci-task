using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._12._2023_2ci_task
{
    internal class sels
    {
        public double C;
        public sels(double c)
        {
            C = c;
        }
        public static implicit operator kelvin(sels sel)
        {
            return new kelvin(sel.C - 5);
        }
    }
}
