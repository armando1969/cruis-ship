using System;
using System.Collections.Generic;
using CSBL;
using CSModels;

namespace CSUI
{
    public class SearchPassbyName : ISMenu
    {
        private IPassengerBL _passBL;
        public SearchPassbyName(IPassengerBL p_passBL)
        {
            _passBL = p_passBL;
        }

        public void Menu()
        {
            List<Passenger> listOfPass = _passBL.GetPassenger(ShowPassengers._findPass.PName);

            Console.WriteLine("This is the search result");
            foreach (Passenger pass in listOfPass)
            {
                Console.WriteLine("====================");
                Console.WriteLine(pass);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[0] - Go Back");
        }

        public MenuChoices UserChoice()
        {
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    return MenuChoices.ShowPassengers;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuChoices.SearchPassbyName;
            }
        }
    }
}