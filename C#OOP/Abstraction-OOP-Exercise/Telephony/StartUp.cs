using System;
using System.Linq;

namespace Telephony
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] websites = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var phoneNumber in phoneNumbers)
            {
                if (!phoneNumber.All(c=> char.IsDigit(c)))
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }

                if (phoneNumber.Length==7)
                {
                    ICallable phone = new StationaryPhone();
                    Console.WriteLine(phone.Call(phoneNumber));
                }
                else if (phoneNumber.Length == 10)
                {
                    ICallable smartPhone = new Smartphone();
                    Console.WriteLine(smartPhone.Call(phoneNumber));
                }    
            }

            foreach (var website in websites)
            {
                if (website.Any(c=>char.IsDigit(c)))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    IBrowsable smartphone = new Smartphone();              
                    Console.WriteLine(smartphone.Browse(website));
                }
            }
        }
    }
}
