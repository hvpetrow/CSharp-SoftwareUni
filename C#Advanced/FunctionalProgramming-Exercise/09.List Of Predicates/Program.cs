using System;
using System.Linq;

namespace _09.List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int[], bool> predicateFunction = (x, arr) =>
          {
              bool flag = true;

              foreach (var item in arr)
              {
                  if (x%item != 0)
                  {
                      flag = false;

                  }
              }

              if (flag == true)
              {

                  return true;
              }
              else
              {
                  return false;
              }

          };

            int n = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Distinct().ToArray();
            var array = Enumerable.Range(1, n).ToArray();

            Action<int[]> print = x => Console.WriteLine(String.Join(" ", x));
            int[] filtered = array.Where((x, arr) => predicateFunction(x, numbers)).ToArray();
            print(filtered);
        }
    }
}
