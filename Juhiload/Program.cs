using System;

namespace Juhiload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            if (yearOfBirth > 2004)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada.");
            }
            else if (yearOfBirth < 2004)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada.");
            }
            if (yearOfBirth == 2004)
            {
                Console.WriteLine("Palju õnne! Nüüd sa saad juhiluba taotleda.");
            }

           
        }
    }
}
