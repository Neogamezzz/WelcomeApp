using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Jak masz na imię?");
                var name = Console.ReadLine();
                Console.WriteLine("Napisz swój rok urodzenia (yyyy):");
                var birthdayYear = Console.ReadLine();
                Console.WriteLine("Napisz miesiac urodzenia (mm):");
                var birthdayMonth = Console.ReadLine();
                Console.WriteLine("Napisz dzien urodzenia (dd):");
                var birthdayDay = Console.ReadLine();
                var birthday = $"{birthdayDay}.{birthdayMonth}.{birthdayYear}";
                DateTime birth = Convert.ToDateTime(birthday);
                DateTime dateNow = DateTime.Now;
                TimeSpan difference = dateNow - birth;
                var years = Math.Floor(difference.Days / 365.25);
                Console.WriteLine("Napisz swoje miejsce urodzenia");
                var placeOfBirth = Console.ReadLine();
                Console.WriteLine($"Cześć {name}! Urodziłeś się w {placeOfBirth} i masz {years} lat.");
            }
            catch (Exception)
            {
                Console.WriteLine("Coś poszło nie tak!");
            }
        }
    }
}
