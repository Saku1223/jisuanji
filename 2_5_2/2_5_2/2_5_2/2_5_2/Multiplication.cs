using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_5_2
{
    class Multiplication:Manners
    {
        public override void compute(float number1, float number2)//float类型的计算
        {
            Console.WriteLine("{0}*{1}={2}", number1, number2, number1 * number2);
        }
        public override void compute(string number1, string number2)//string类型错误提示
        {
            Console.WriteLine("{0}和{1}为字符型无法计算", number1, number2);
        }
        public override void compute(int number1, int number2)//重载int类型的计算
        {
            Console.WriteLine("{0}*{1}={2}", number1, number2, number1 * number2);
        }
    }
}
