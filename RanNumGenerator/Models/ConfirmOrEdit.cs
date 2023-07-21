// // this is the file where I will be creating the class for generating a random number


// using System;
// using System.Collections.Generic; // I need this line of code so it helps me import things like C# lists, Dictionary, etc... Without it I won't be able to make use of Dictionaries or Lists in C#

// // Don't forget a namespace is a collection of multiple classes
// // I would be needing this namespace if for instance, I want to update this application to not only 
// // Be able to generate random numbers from 1-100(like this file will be doing but also about a 1-1000 type of thing)
// namespace RanNumGenerator.Models
// {
//     public class RandomNumberGenerator
//     {
//         private static readonly Random myRandom = new Random();


//         public int min {get; set;}
//         public int max {get; set;}

//         // writing my list
//         private static List<RandomNumberGenerator> _instance = new List<RandomNumberGenerator>();


//         // Making the public version of the list
//         public List<RandomNumberGenerator> ListForStoringValues
//         {
//             get { return _instance; }
//             set { _instance = value; }
        
//         }




//         // My constructor that takes in both min and max values
        
//         public RandomNumberGenerator(int myMin, int myMax)
//         {

//             min = myMin;
//             max = myMax;
//             _instance.Add(this);
//             // Now we need to run a branch to determine and ensure min is less than max
           


//         // I need a confirm or Edit method that my user can use to confirm whether the minimum or maximum value they enterred was correct
//         // But first I will be needing a constructor also that can help me out with the 2 inputs I am passing in it(which are min and max)

//         // writing the constructor
     


//         }


//         // writing a method to be used on my constructor for the branching of whether min > max so I can switch them up

//         public int GetRandomNumber()
//         {
//              if (min > max)
//             {
//                 // now we swap it up if the myMin is greater than the myMax which is not what we want

//                 int temp = min;
//                 min = max;
//                 max = temp;

//             }

//             // Now we generate our random number 
//             // Generate a random number between min and max (inclusive on min exclusive on max)
//             // the .Next() method in C# returns a non-negative random integer.
//             //         int Random.Next(int maxValue)
//             // maxValue: The exclusive upper bound of the random number to be generated. maxValue must be greater than or equal to 0.
//             // int Random.Next(int minValue, int maxValue)
//             // minValue: The inclusive lower bound of the random number returned.


//             // Returns a random integer that is within a specified range.

//             // Returns a non-negative random integer that is less than the specified maximum.
//             return myRandom.Next(min, max);

//         // I couldnt make use of the double type because it seems the .Next() method only works with integers; just like it says: THe method helps to return a non negative random integer
//         // Even the temp variable didn't work also because I used the wrong datatype(double) for it.


//         }
//     }


// }