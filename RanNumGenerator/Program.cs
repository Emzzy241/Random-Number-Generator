// This is the Entry point file for my C# application; this file will serve as a gateway for C# to enter my application


using System;
using System.Collections.Generic;

using RanNumGenerator.Models;

class Program
{
    static void Main()
    {

        

        Console.WriteLine("Welcome to the Random Number Generator Made by Dynasty");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Enter in the range of random numbers you want to generate");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Firstly, enter the minimum value of random numbers you want");
        string userMinVal = Console.ReadLine();
        int userMinValInt = int.Parse(userMinVal);

        Console.WriteLine();
        Console.WriteLine("Next, enter the maximum value of random numbers you want");
        string userMaxVal = Console.ReadLine();
        int userMaxValInt = int.Parse(userMaxVal);

        Console.WriteLine();
        Console.WriteLine();

        // Asking users if they would like to continue 
        Console.WriteLine("Would you like to continue?, enter yes or no");
        Console.WriteLine();
        string userContinue = Console.ReadLine().ToUpper();


       
        switch (userContinue)
        {
            case "YES":
                Console.WriteLine("The Number Generated is: ");
                // Console.WriteLine("The range of random values you ");
                // Now that I have written the method in my business logic file(the file inside of Models), now its time to work with the code there in my UserInterface logic file(which is this file)

                // Now its time to reinstantiate(make an example of my RandomNumberGenerator class) and save it up in a variable

                RandomNumberGenerator rng = new RandomNumberGenerator();
                int randomNumber = rng.GetRandomNumber(userMinValInt, userMaxValInt);
                Console.WriteLine(randomNumber);
                break;

            case "NO":
                Console.WriteLine("Goodbye My dear User");
                break;

        }






    }
}