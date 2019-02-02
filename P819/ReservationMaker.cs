//DATE          DEVELOPER          DESCRIPTION
//2019-01-27    jmsnmrtn           PROJECT CREATED, COMMITED, AND PUSHED (ALL CSx ASSIGNMENTS ARE PRIVATE REPOS)
//2019-02-2     jmsnmrtn           Main program logic is completed. Needs polishing up as well as debug walk through.


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
                FirstClass();
            }
            else
            {
                EconClass();
            }
        }
        static void FirstClass()//First class method
        {
            for (int i = 0; i <= 4; i++)
            {
                if (seats[i] == false)
                {
                    seats[i] = true;
                    break;
                }
                else if (seats[4] == true)
                {
                    if (seats[9] == true)
                    {
                        Console.WriteLine("FLIGHT COMPLETELY FULL");
                    }
                    else
                    {
                        Console.Write("First class is fully booked. Would you like to fly economy? y[1] n[2]: ");
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            EconClass();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Next flight leaves in 3 hours.");
                            break;
                        }
                    }
                }
            }
        }
        static void EconClass()//Econ class method
        {
            for (int i = 5; i <= 9; i++)
            {
                if (seats[i] == false) 
                {
                    seats[i] = true;
                    break;
                }
                else if (seats[9] == true) 
                {
                    if (seats[4] == true) 
                    {
                        //TODO: Handle when first class is full
                    }
                    else
                    {
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            FirstClass();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Next flight is in 3 hours");
                            break;
                        }
                    }
                }
            }
        }
        static void PrintSeatList()
        {
            for (int i = 0; i < seats.Length; i++)
            {
                if (seats[i] == false)
                {
                    string status = "Available";
                    Console.WriteLine($"First Class Seat {i+1} is {status}");
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
