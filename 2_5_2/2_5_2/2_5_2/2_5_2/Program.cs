using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Manners> manners = new List<Manners>();
            Add add = new Add();//加法 list下标为0
            Subtraction subtraction = new Subtraction();//减法 list下标为1
            Multiplication multiplication = new Multiplication();//乘法 list下标为2
            Division division = new Division();//除法 list下标为3
            Remainder remainder = new Remainder();//取余 list下标为4
            And and = new And();//按位与运算 list下标为5
            manners.Add(add);
            manners.Add(subtraction);
            manners.Add(multiplication);
            manners.Add(division);
            manners.Add(remainder);
            manners.Add(and);                      
            try
            {
                int choice_1;
                Console.WriteLine("请选择输入的数值类型");
                Console.WriteLine("1.整数");
                Console.WriteLine("2.小数");
                Console.WriteLine("3.字符串");             
                choice_1 = int.Parse(Console.ReadLine());
                switch (choice_1)
                {
                    case 1:
                        {                           
                            Console.WriteLine("请选择要执行的操作");
                            Console.WriteLine("1.加法");
                            Console.WriteLine("2.减法");
                            Console.WriteLine("3.乘法");
                            Console.WriteLine("4.除法");
                            Console.WriteLine("5.取余");
                            Console.WriteLine("6.按位与运算");
                            int choice_2;
                            choice_2 = int.Parse(Console.ReadLine());
                            switch (choice_2)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("请输入两个值");
                                        manners[0].Number1_i = int.Parse(Console.ReadLine());
                                        manners[0].Number2_i = int.Parse(Console.ReadLine());                                        
                                        manners[0].compute(manners[0].Number1_i, manners[0].Number2_i);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("请输入两个值");
                                        manners[1].Number1_i = int.Parse(Console.ReadLine());
                                        manners[1].Number2_i = int.Parse(Console.ReadLine());                                       
                                        manners[1].compute(manners[1].Number1_i, manners[1].Number2_i);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("请输入两个值");
                                        manners[2].Number1_i = int.Parse(Console.ReadLine());
                                        manners[2].Number2_i = int.Parse(Console.ReadLine());                                      
                                        manners[2].compute(manners[2].Number1_i, manners[2].Number2_i);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("请输入两个值");
                                        manners[3].Number1_i = int.Parse(Console.ReadLine());
                                        manners[3].Number2_i = int.Parse(Console.ReadLine());                                       
                                        manners[3].compute(manners[3].Number1_i, manners[3].Number2_i);
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.WriteLine("请输入两个值");
                                        manners[4].Number1_i = int.Parse(Console.ReadLine());
                                        manners[4].Number2_i = int.Parse(Console.ReadLine());                                       
                                        manners[4].compute(manners[4].Number1_i, manners[4].Number2_i);
                                        break;
                                    }
                                case 6:
                                    {
                                        Console.WriteLine("请输入两个值");
                                        manners[5].Number1_i = int.Parse(Console.ReadLine());
                                        manners[5].Number2_i = int.Parse(Console.ReadLine());                                      
                                        manners[5].compute(manners[5].Number1_i, manners[5].Number2_i);
                                        break;
                                    }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("请选择要执行的操作");
                            Console.WriteLine("1.加法");
                            Console.WriteLine("2.减法");
                            Console.WriteLine("3.乘法");
                            Console.WriteLine("4.除法");
                            Console.WriteLine("5.取余");
                            Console.WriteLine("6.按位与运算");
                            int choice_2;
                            choice_2 = int.Parse(Console.ReadLine());
                            switch (choice_2)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("请输入两个值");
                                        manners[0].Number1_f = float.Parse(Console.ReadLine());
                                        manners[0].Number2_f = float.Parse(Console.ReadLine());
                                        manners[0].compute(manners[0].Number1_f, manners[0].Number2_f);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("请输入两个值");
                                        manners[1].Number1_f = float.Parse(Console.ReadLine());
                                        manners[1].Number2_f = float.Parse(Console.ReadLine());
                                        manners[1].compute(manners[1].Number1_f, manners[1].Number2_f);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("请输入两个值");
                                        manners[2].Number1_f = float.Parse(Console.ReadLine());
                                        manners[2].Number2_f = float.Parse(Console.ReadLine());
                                        manners[2].compute(manners[2].Number1_f, manners[2].Number2_f);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("请输入两个值");
                                        manners[3].Number1_f = float.Parse(Console.ReadLine());
                                        manners[3].Number2_f = float.Parse(Console.ReadLine());
                                        manners[3].compute(manners[3].Number1_f, manners[3].Number2_f);
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.WriteLine("请输入两个值");
                                        manners[4].Number1_f = float.Parse(Console.ReadLine());
                                        manners[4].Number2_f = float.Parse(Console.ReadLine());
                                        manners[4].compute(manners[4].Number1_f, manners[4].Number2_f);
                                        break;
                                    }
                                case 6:
                                    {
                                        Console.WriteLine("请输入两个值");
                                        manners[5].Number1_f = float.Parse(Console.ReadLine());
                                        manners[5].Number2_f = float.Parse(Console.ReadLine());
                                        manners[5].compute(manners[5].Number1_f, manners[5].Number2_f);
                                        break;
                                    }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("请选择要执行的操作");
                            Console.WriteLine("1.加法");
                            Console.WriteLine("2.减法");
                            Console.WriteLine("3.乘法");
                            Console.WriteLine("4.除法");
                            Console.WriteLine("5.取余");
                            Console.WriteLine("6.按位与运算");
                            int choice_2;
                            choice_2 = int.Parse(Console.ReadLine());
                            switch (choice_2)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("请输入两个值");
                                        manners[0].Number1_s = Console.ReadLine();
                                        manners[0].Number2_s = Console.ReadLine();
                                        manners[0].compute(manners[0].Number1_s, manners[0].Number2_s);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("请输入两个值");
                                        manners[1].Number1_s = Console.ReadLine();
                                        manners[1].Number2_s = Console.ReadLine();
                                        manners[1].compute(manners[1].Number1_s, manners[1].Number2_s);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("请输入两个值");
                                        manners[2].Number1_s = Console.ReadLine();
                                        manners[2].Number2_s = Console.ReadLine();
                                        manners[2].compute(manners[2].Number1_s, manners[2].Number2_s);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("请输入两个值");
                                        manners[3].Number1_s = Console.ReadLine();
                                        manners[3].Number2_s = Console.ReadLine();
                                        manners[3].compute(manners[3].Number1_s, manners[3].Number2_s);
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.WriteLine("请输入两个值");
                                        manners[4].Number1_s = Console.ReadLine();
                                        manners[4].Number2_s = Console.ReadLine();
                                        manners[4].compute(manners[4].Number1_s, manners[4].Number2_s);
                                        break;
                                    }
                                case 6:
                                    {
                                        Console.WriteLine("请输入两个值");
                                        manners[5].Number1_s = Console.ReadLine();
                                        manners[5].Number2_s = Console.ReadLine();
                                        manners[5].compute(manners[5].Number1_s, manners[5].Number2_s);
                                        break;
                                    }
                            }
                            break;
                        }
                }             
            }
            catch
            {
                Console.WriteLine("发生异常，请重启程序");
            }
        }
    }
}
