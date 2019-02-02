//DATE          DEVELOPER          DESCRIPTION
//2019-01-27    jmsnmrtn           PROJECT CREATED, COMMITED, AND PUSHED (ALL CSx ASSIGNMENTS ARE PRIVATE REPOS)
//2019-2-2      jmsnmrtn           ASSIGNMENT DUPELIM FINISHED 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 8.12 (Duplicate Elimination) Use a one-dimensional array to solve the following problem: Write an app that inputs five numbers, each between 10 and 100, inclusive. As each number is read, display it only if it’s not a duplicate of a number already read. Provide for the “worst case,” in which all five numbers are different. Use the smallest possible array to solve this problem. Display the complete set of unique values input after the user inputs each new value.
 */


namespace DuplicateElimination
{
    class DupEliminator
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[5];//Make new int array with length 5

            for (int i = 0; i < numberArray.Length; i++)//Going through array
            {
                while (numberArray[i] <= i)//Adding values to the array until we reach i=5
                {
                    Console.Write("Please type a number between 10 and 100: ");//Getting input from user.
                    numberArray[i] = int.Parse(Console.ReadLine());//Reading input
                    while (CheckBounds(numberArray[i]) == true)//Check to see if the user entered a number between the set bounds of 10-100
                    {
                        Console.Write("Error: Please type an integer between 10 and 100: ");//If the user did not input the correct number in the range. Asked to try again.
                        numberArray[i] = int.Parse(Console.ReadLine());//Reading input
                    }
                }
            }
            int[] arrayWithoutDupes = numberArray.Distinct().ToArray();//Create a new array without dupes using LINQ 
            //Used this link for the LINQ useage - https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.distinct?view=netframework-4.7.2 
            for (int i = 0; i < arrayWithoutDupes.Length; i++)//Going through the new array and printing the values, without the dupes.
            {
                Console.WriteLine(arrayWithoutDupes[i]);
            }
        }
        static bool CheckBounds(int input)//Boolean method that will return true if its within the bounds of 10-100, false if not.
        {
            if (input < 10 || input > 100)
            {
                return true;
            }
            else
            {
                return false;
            }
            //TODO: Print values after adding them.
        }
    }
}
