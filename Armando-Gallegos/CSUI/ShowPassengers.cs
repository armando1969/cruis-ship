using System;
using System.Collections.Generic;
using CSModels;
using CSBL;

namespace CSUI
{
    public class ShowPassengers : ISMenu
    {
        private IPassengerBL _passBL;

        public static Passenger _findPass = new Passenger();

        //Another dependency Injection
        public ShowPassengers(IPassengerBL p_actBL)
        {
            _passBL = p_actBL;
        }

        public MenuChoices UserChoice()
        {
            string ActivityChoice = Console.ReadLine();
            switch(ActivityChoice)
            {
                    case "0":
                        return MenuChoices.AdminMenu;
                    case "1":
                        Console.WriteLine("Enter the Name of the Passenger you would like to find.");
                        _findPass.PName = Console.ReadLine();
                        return MenuChoices.SearchPassbyName;
                    case "2":
                        Console.WriteLine("Enter the Cabin Number of the Passenger you want to find.");
                        try
                        {
                            _findPass.CabinNo = Int32.Parse(Console.ReadLine());
                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine("Numeric Value Expected.");
                            Console.WriteLine("Please Press Enter to Continue");
                            Console.ReadLine();
                            return MenuChoices.ShowPassengers;
                        }
                    return MenuChoices.PassActivitesAdmin;
                default:
                        Console.WriteLine("Please enter a valid response!");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        return MenuChoices.ShowPassengers;
            }
        }

        public void Menu()
        {
            Console.WriteLine("List of Passengers");
            List<Passenger>listOfPassengers = _passBL.GetAllPassengers();
            foreach (Passenger pass in listOfPassengers)
            {
                Console.WriteLine("================");
                Console.WriteLine(pass);
                Console.WriteLine("=================");
            }
            Console.WriteLine("[2] - Select a Passenger by Cabin No.");
            Console.WriteLine("[1] - Select a Passenger by Name.");
            Console.WriteLine("[0] - Go Back");
        }
    }
}