using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础.装箱和拆箱
{
    class Box
    {
        private int m_iMax;
        private double m_dMax;
        private long m_lMax;
        public void Packing(int number)
        {
            double dnumber = (double)number;

        }
        public void Packing(double number)
        {
            int inumber = (int)number;
            double dnumber = (double)inumber;

        }
    }
}
