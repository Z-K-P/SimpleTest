using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础.属性和字段
{
    class Person
    {
        private int m_iAge;
        private string m_strName;
        private double m_dHeight;
        public int Age
        {
            get { return m_iAge; }
            set { m_iAge = value; }
        }
        public string Name { get; set;}
        public double Height { get; set; } = 50;
    }
}
