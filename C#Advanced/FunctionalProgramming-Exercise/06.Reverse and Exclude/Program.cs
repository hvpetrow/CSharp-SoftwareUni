using System;
using System.Linq;

namespace _06.Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int diveder = int.Parse(Console.ReadLine());

            Predicate<int> predicate = n=> n%diveder!=0;
            Func<Predicate<int>, int[], int[]> func = (predic, ints) => ints.Where(n=>predic(n)).ToArray();
            Func<int[], int[]> reverseFunc = ints => ints.Reverse().ToArray();

            numbers = func(predicate, numbers);
            numbers = reverseFunc(numbers);

            Console.WriteLine(String.Join(" " , numbers));



        }
    }
}
