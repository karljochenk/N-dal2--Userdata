using System;

namespace InstagramVanuseKontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun, sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if(userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagram'i konto luua.");
            }
            else if(userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagram'i kontot luua.");
            }
            else
            {
                Console.WriteLine("Oledki 13, nüüd saad endale Instagram'i konto luua");
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}