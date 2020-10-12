using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_5_2
{
    class Subtraction:Manners
    {
        public override void compute(float number1, float number2)//float类型的计算
        {
            Console.WriteLine("{0}-{1}={2}", number1, number2, number1 - number2);
        }
        public override void compute(string str1, string str2)//重载string类型的计算
        {                     
                  string str3="";
                  for (int i = 0; i < str1.Length; i++)
                  {
                      if (str1[i] == str2[0])
                      {
                          for (int j = 0; j < str1.Length - str2.Length; j++)
                          {
                              if(j<i)
                                  str3 += str1[j];
                          }
                          for (int k = i + str2.Length; k < str1.Length; k++)
                          {
                              str3 += str1[k];
                          }
                      }
                  }
                  if (str3 =="")
                  {
                      Console.WriteLine("无法相减");  
                  }
                  else
                    Console.WriteLine("{0}-{1}={2}", str1, str2, str3);              
         }
        public override void compute(int number1, int number2)//重载int类型的计算
        {
            Console.WriteLine("{0}-{1}={2}", number1, number2, number1 - number2);
        }
    }
}
