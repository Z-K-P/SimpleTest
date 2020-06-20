using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础.引用
{
    class SimpleMath
    {
        private int m_iNumber = 1;
        private int m_iSize = 2;

        //
        public void Ref(int number, ref int size)
        {
            number = m_iNumber;
            size = m_iSize;
        }
        //
        public int Out(int number, out int size)
        {
            number = m_iNumber;
            size = m_iSize;
            return size;
        }
        static void Main(string[] args)
        {
            int number = 0;
            int size = 2;
            SimpleMath math = new SimpleMath();
            math.Ref(number,ref size);
            //number = 5 size = 13
            math.Out(number,out size);
            //number = 5 size = number


        }
    }
}
