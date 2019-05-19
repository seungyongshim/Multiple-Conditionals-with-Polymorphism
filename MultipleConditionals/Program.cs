using System;

namespace MultipleConditionals
{
    public class ClassWithConditionals
    {
        private bool _conditional1;
        private EnumeratedType _conditional2;

        public ClassWithConditionals(bool cond1, EnumeratedType cond2)
        {
            _conditional1 = cond1;
            _conditional2 = cond2;
        }

        public void Method1()
        {
            if (_conditional1)
            {
                //do something
            }
            else
            {
                //do something else
            }
        }

        public void Method2()
        {
            switch (_conditional2)
            {
                case EnumeratedType.CASE1:
                    //do something
                    break;
                case EnumeratedType.CASE2:
                    //do something else
                    break;
                case EnumeratedType.CASE3:
                    //do something entirely different
                    break;
            }
        }
    }

    public enum EnumeratedType
    {
        CASE1,
        CASE2,
        CASE3
    }


    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
