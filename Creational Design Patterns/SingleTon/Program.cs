/*
   SingleTon => You are using only one Instance From Class For Life Of Program.
*/
using System;

namespace SingleTonDesignPattern
{
    public class SingleTon
    {
        private static readonly SingleTon Instace_SL = null;

        private SingleTon() { }

        // If Null created Instance otherwise return instane
        public static SingleTon get_Instance()
        {
            return Instace_SL ?? new SingleTon();
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            SingleTon x = SingleTon.get_Instance();
            Console.WriteLine(x);
            SingleTon y = SingleTon.get_Instance();
            Console.WriteLine(y);
            SingleTon z = SingleTon.get_Instance();
            Console.WriteLine(z);
        }
    }
}
