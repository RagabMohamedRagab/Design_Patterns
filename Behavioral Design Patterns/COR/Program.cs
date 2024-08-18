using System;
using COR.Chin_Of_Resposibilty;

namespace COR
{
    class Program
    {
        static void Main(string[] args)
        {
            // The other part of the client code constructs the actual chain.
            var monkey = new MonkeyHandler();
            var dog = new DogHandler();

            monkey.SetNext(monkey).SetNext(dog);
        }
    }
}
