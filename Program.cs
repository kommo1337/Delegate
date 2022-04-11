using System;

namespace ConsoleApp14
{
    public delegate string Delegata(string a, int b);
    public delegate void VoidDelegate();
    public delegate bool BoolDelegate(int a, int b);
    public delegate bool BoolStringDelegate(string a, string b);

    class Program
    {
        static void Main(string[] args)
        {
            Delegata DT = (string str, int a) => str + Convert.ToString(a);            
            Console.WriteLine(DT("Talalaev ",58));
            VoidDelegate VD = () => Console.WriteLine("Talalaev");
            VD();
            BoolDelegate BD = (x, y) => x == y;
            bool res = BD(12, 9);
            Console.WriteLine(res);
            BoolStringDelegate BSD = (x, y) => x == y;
            bool resString = BSD("Talalaev","Talalaev");
            Console.WriteLine(res.ToString());

        }
    }
}
