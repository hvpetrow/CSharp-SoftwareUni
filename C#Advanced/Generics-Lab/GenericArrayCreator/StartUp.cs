using System;

namespace GenericArrayCreator
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            var arrayGeneric = ArrayCreator<string>.Create(5, "Ico");
            
        }
    }
}
