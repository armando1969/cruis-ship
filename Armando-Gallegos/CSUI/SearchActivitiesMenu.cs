using System;
using System.Collections.Generic;
using CSModels;
using CSBL;

namespace CSUI
{
    public class SearchActivitiesMenu : ISMenu
    {
        private IPassengerBL _passBL;

        public static Passenger _findPass = new Passenger();

        //Another dependency Injection
        public SearchActivitiesMenu(IPassengerBL p_actBL)
        {
            _passBL = p_actBL;
        }

        public MenuChoices UserChoice()
        {
            string ActivityChoice = Console.ReadLine();
            switch(ActivityChoice)
            {
                    case "0":
                        return MenuChoices.ActivitiesMenu1;
                    case "1":
                        Console.WriteLine("Enter the Cabin Number of the Passenger.");
                        try
                        {
                            _findPass.CabinNo = Int32.Parse(Console.ReadLine());
                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine("Numeric Value Expected.");
                            Console.WriteLine("Please Press Enter to Continue");
                            Console.ReadLine();
                            return MenuChoices.SearchActivitiesMenu;
                        }
                    return MenuChoices.PassActivities;
                default:
                        Console.WriteLine("Please enter a valid response!");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        return MenuChoices.SearchActivitiesMenu;
            }
        }

        public void Menu()
        {
            Console.WriteLine("List of Passengers Activities");
           /* List<Passenger>listOfPassengers = _passBL.GetAllPassengers();
            foreach (Passenger pass in listOfPassengers)
            {
                Console.WriteLine("================");
                Console.WriteLine(pass);
                Console.WriteLine("=================");
            }*/
            Console.WriteLine("[1] - Enter Your Cabin No.");
            Console.WriteLine("[0] - Go Back");
        }
    }
}
    
        
