using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_5_2
{
    class Add:Manners
    {
        public override void compute(float number1, float number2)//float类型的计算
        {
            Console.WriteLine("{0}+{1}={2}", number1, number2, number1 + number2);
        }
        public override void compute(string number1, string number2)//重载string类型的计算
        {
            Console.WriteLine("{0}+{1}={2}", number1, number2, number1 + number2);
        }
        public override void compute(int number1, int number2)//重载int类型的计算
        {
            Console.WriteLine("{0}+{1}={2}", number1, number2, number1 + number2);
        }
    }
}
