using System;
using System.Linq;

namespace Tuples
{
  public class Program
    {
        static void Main(string[] args)
        {
            string[] stringInputInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string town = (String.Join(" ", stringInputInfo.Skip(3)));

            string[] secondInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int secondIntTupleInput = int.Parse(secondInput[1]);
            bool isDrunk = secondInput[2] == "drunk";
            string[] thirdInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);          
            double thirdInputDouble = double.Parse(thirdInput[1]);

            Tuples.Tuple<string, string,string> myStringTuple = new Tuple<string, string,string>($"{stringInputInfo[0]} {stringInputInfo[1]}",stringInputInfo[2] ,town);
            Tuples.Tuple<string, int,bool> myIntTuple = new Tuple<string, int,bool>(secondInput[0] , secondIntTupleInput , isDrunk);
            Tuples.Tuple<string, double,string> myDoubleTuple= new Tuple<string, double,string>(thirdInput[0] , thirdInputDouble , thirdInput[2]);

            Console.WriteLine(myStringTuple.PrintIt());
            Console.WriteLine(myIntTuple.PrintIt());
            Console.WriteLine(myDoubleTuple.PrintIt());
        }
    }
}
