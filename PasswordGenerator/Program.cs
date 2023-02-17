using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {

            string upperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerLetters = upperLetters.ToLower();
            string numbers = "0123456789";
            string special = "~!@#$%^&*()";

            Console.WriteLine("Ile ma być wielkich liter");
            int upperLettersNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Ile ma być małych liter");
            int lowerLettersNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Ile ma być cyfr liter");
            int numbersHowMuch = int.Parse(Console.ReadLine());
            Console.WriteLine("Ile ma być znaków specjalnych liter");
            int specialNumber = int.Parse(Console.ReadLine());

            Random randomMachine = new Random();
            string password = "";

            for (int i = 0; i < upperLettersNumber; i++)
            {
                char symbol = upperLetters[randomMachine.Next(upperLetters.Length)];
                password = password.Insert(randomMachine.Next(password.Length), symbol.ToString());
                Console.WriteLine(password + " " + password.Length.ToString());
            }
            for (int i = 0; i < lowerLettersNumber; i++)
            {
                char symbol = lowerLetters[randomMachine.Next(lowerLetters.Length)];
                password = password.Insert(randomMachine.Next(password.Length), symbol.ToString());
                Console.WriteLine(password + " " + password.Length.ToString());
            }
            for (int i = 0; i < numbersHowMuch; i++)
            {
                char symbol = numbers[randomMachine.Next(numbers.Length)];
                password = password.Insert(randomMachine.Next(password.Length), symbol.ToString());
                Console.WriteLine(password + " " + password.Length.ToString());
            }
            for (int i = 0; i < specialNumber; i++)
            {
                char symbol = special[randomMachine.Next(special.Length)];
                password = password.Insert(randomMachine.Next(password.Length), symbol.ToString());
                Console.WriteLine(password + " " + password.Length.ToString());
            }

            Console.WriteLine("Twoje hasło to: " + password);


        }
    }
}
