using System;
using System.Data;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Asking the user for the magic number and storing the number
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1,56);

        int guess = 0;
        int numberOfGuesses = 0;

        while (guess != magicNumber){
            Console.Write("What is your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber){
                System.Console.WriteLine("Higher");
                numberOfGuesses++;
            } else if (guess > magicNumber){
                System.Console.WriteLine("Lower");
                numberOfGuesses++;
            }
        }
        System.Console.WriteLine("You got the number! ");
        System.Console.WriteLine($"It took you {numberOfGuesses} guesses! ");

        



    }


}