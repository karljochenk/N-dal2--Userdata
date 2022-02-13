namespace _2.nädal
{
    internal class ProgramBase
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Palun, sisesta oma sünniaasta:"); //programm küsib kasutaja sünniaastat;
            int yearOfBirth = Convert.ToInt32(Console.ReadLine()); //programm arvutab kasutaja vanust;

            int userAge = 2022 - yearOfBirth; //programm kuvab kasutaja vanust konsloolis;

            //string interpolation

            Console.WriteLine($"Oled {userAge} aastat vana. "); //Console.WriteLine("Oled" + userAge + "aastat vana.");
        }
    }
}