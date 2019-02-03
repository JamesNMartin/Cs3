//DATE          DEVELOPER          DESCRIPTION
//2019-01-27    jmsnmrtn           PROJECT CREATED, COMMITED, AND PUSHED (ALL CSx ASSIGNMENTS ARE PRIVATE REPOS)
//2019-02-2     jmsnmrtn           Main program logic is completed. Needs polishing up as well as debug walk through.
//2019-02-2     jmsnmrtn           Added ascii header on program console and added comments to code.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 8.19 (Airline Reservations System) A small airline has just purchased a computer for its new automated reservations system. You have been asked to develop the new system. You’re to write an app to assign seats on each flight of the airline’s only plane (capacity: 10 seats).

Display the following alternatives: Please enter 1 for First Class or 2 for Economy. If the user types 1, your app should assign a seat in the first-class section (seats 1–5). If the user types 2, your app should assign a seat in the economy section (seats 6–10).

Use a one-dimensional array of type bool to represent the seating chart of the plane. Initialize all the elements of the array to false to indicate that all the seats are empty. As each seat is assigned, set the corresponding element of the array to true to indicate that the seat is no longer available.

Your app should never assign a seat that has already been assigned. When the economy section is full, your app should ask the person if it’s acceptable to be placed in the first-class section (and vice versa). If yes, make the appropriate seat assignment. If no, display the message "Next flight leaves in 3 hours."
*/

namespace AirlineReservations
{
    class ReservationMaker
    {

        static bool[] seats = new bool[10];

        static void Main(string[] args)
        {
            Console.WriteLine(@"
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
    ___    _      ___               ____                                  __  _                 
   /   |  (_)____/ (_)___  ___     / __ \___  ________  ______   ______ _/ /_(_)___  ____  _____
  / /| | / / ___/ / / __ \/ _ \   / /_/ / _ \/ ___/ _ \/ ___/ | / / __ `/ __/ / __ \/ __ \/ ___/
 / ___ |/ / /  / / / / / /  __/  / _, _/  __(__  )  __/ /   | |/ / /_/ / /_/ / /_/ / / / (__  ) 
/_/__|||_/_/  /_/_/_|_/_/\___/  /_/ |_|\___/____/\___/_/    |___/\__,_/\__/_/\____/_/ /_/____/  
  / ___/__  _______/ /____  ____ ___                                                            
  \__ \/ / / / ___/ __/ _ \/ __ `__ \                                                           
 ___/ / /_/ (__  ) /_/  __/ / / / / /                                                           
/____/\__, /____/\__/\___/_/ /_/ /_/                                                            
     /____/                                                                                     

How to use:
You will be asked to select what class you would like to fly. If your selection is booked you will
be asked if you would like to down grade or upgrade depending on what you orginally picked. If it
is all booked up then you will get a message stating there is a next flight in 3 hours.

* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 

");
            while (true)//While loop to allow user to continue to pick seats while there is still room.
            {
                SeatSelector();//Method to select seat type. 1 is first class and 2 is economy.
            }
        }
        static void SeatSelector()//Method to select seats.
        {
            PrintSeatList();//Print the list of seats after every seat selection.
            Console.WriteLine("Please select your seat type below.");
            Console.Write("Press 1 for first class and 2 for economy: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                FirstClass();//Dealing with the user selection first class. 
            }
            else
            {
                EconClass();//Dealing with the user selection of econ class
            }
        }
        static void FirstClass()//First class method
        {
            for (int i = 0; i <= 4; i++)//0-4 is seats 1-5
            {
                if (seats[i] == false)
                {
                    seats[i] = true;
                    break;
                }
                else if (seats[4] == true)//if seat 4 (in output 4 will read as 5) is full we assume first class is full
                {
                    if (seats[9] == true)//if seat 9 (in output it will read as seat 10) is full we assume all seats are filled, this is becuase we add the T/F flag based on i.
                    {
                        Console.WriteLine("FLIGHT COMPLETELY FULL");
                    }
                    else
                    {
                        Console.Write("First class is fully booked. Would you like to fly economy? y[1] n[2]: ");//Giving the option to select econ class because first class is full
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            EconClass();
                            break;//Breaking out so we dont add 5 people to first class all at once.
                        }
                        else
                        {
                            Console.WriteLine("Next flight leaves in 3 hours.");
                            break;//Again breaking out to avoid incorrect assignment
                        }
                    }
                }
            }
        }
        static void EconClass()//Econ class method
        {
            for (int i = 5; i <= 9; i++)//Seats 5-9 are seats 6-10 
            {
                if (seats[i] == false)//Checking to see if there are available seats in econ. 
                {
                    seats[i] = true;//if there is a free seat we assign it here.
                    break;
                }
                else if (seats[9] == true)//if all 10 seats are full we assume the plane is full
                {
                    if (seats[4] == true) //Checking to see if first class is full
                    {
                        Console.WriteLine("FLIGHT COMPLETELY FULL");
                    }
                    else
                    {
                        Console.Write("First class is fully booked. Would you like to fly first class? y[1] n[2]: ");//Giving the option to select first class because econ class is full
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            FirstClass();//If they accept first class we sent them to the first class method
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Next flight is in 3 hours.");//if they decline the offer we let them know there will be another flight in three hours
                            break;
                        }
                    }
                }
            }
        }
        static void PrintSeatList()//Simple method to print the seat array.
        {
            for (int i = 0; i < seats.Length; i++)
            {
                if (seats[i] == false)
                {
                    string status = "Available";
                    Console.WriteLine($"First Class Seat {i+1} is {status}");//I like the idea better of having the seat show as avail/unavail rather than T/F.
                }
                else
                {
                    string status = "Unavailable";
                    Console.WriteLine($"Economy Class Seat {i +1} is {status}");
                }
            }
        }
    }
}
