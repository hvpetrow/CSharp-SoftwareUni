using System;

namespace GenericScale
{
  public  class StartUp
    {
        static void Main(string[] args)
        {
            var equality = new EqualityScale<string>("2", "3");

            Console.WriteLine(equality.AreEqual());
        }
    }
}
