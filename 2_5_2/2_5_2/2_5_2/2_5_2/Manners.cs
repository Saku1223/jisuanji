using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_5_2
{
    abstract class Manners
    {
        int _number1_i = 0, _number2_i = 0;

        public int Number2_i
        {
            get { return _number2_i; }
            set { _number2_i = value; }
        }

        public int Number1_i
        {
            get { return _number1_i; }
            set { _number1_i = value; }
        }
        float _number1_f = 0, _number2_f = 0;

        public float Number2_f
        {
            get { return _number2_f; }
            set { _number2_f = value; }
        }

        public float Number1_f
        {
            get { return _number1_f; }
            set { _number1_f = value; }
        }
        string _number1_s = "", _number2_s = "";

        public string Number2_s
        {
            get { return _number2_s; }
            set { _number2_s = value; }
        }

        public string Number1_s
        {
            get { return _number1_s; }
            set { _number1_s = value; }
        }
        public abstract void compute(float number1,float number2);
        public abstract void compute(string number1, string number2);
        public abstract void compute(int number1, int number2);    
    }
}
