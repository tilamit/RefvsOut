using System;

namespace RefvsOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int newVal1 = 20;
            ValClass.AddNo(newVal1);
            Console.WriteLine(newVal1);

            int newVal2 = 20;
            RefClass.AddNoWithRef(ref newVal2);
            Console.WriteLine(newVal2);
        }
    }

    public static class ValClass
    {
        public static int AddNo(int val)
        {
            val = val + 20;

            return val;
        }
    }

    public static class RefClass
    {
        public static int AddNoWithRef(ref int val)
        {
            val = val + 20; //With ref and out, actual value isn't passed to the
                                         //method, instead a memory address pointer is referenced to keep track of changes

            return val;
        }

        public static int AddNoWithOut(out int val)
        {
            val = 0; //Here the parameter val has to be initialized
            val = val + 20;

            return val;
        }
    }
}
