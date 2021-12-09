using CSBL;
using CSModels;
using System;
using System.Collections.Generic;

namespace CSUI
{
    public class PassActivies : ISMenu
    {
        private IPassengerBL _passBL;

        public PassActivies(IPassengerBL p_passBL)
        {
            this._passBL = p_passBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of Activities");
            List<PassengerActivities> listOfActivities = _passBL.GetPassActivities(SearchActivitiesMenu._findPass);

            foreach (PassengerActivities passAct in listOfActivities)
            {
                Console.WriteLine("================");
                Console.WriteLine(passAct);
                Console.WriteLine("=================");
            }
            Console.WriteLine("[0] - Go Back");
        }

        public MenuChoices UserChoice()
        {
            string ActivityChoice = Console.ReadLine();
            switch (ActivityChoice)
            {
                case "0":
                    return MenuChoices.SearchActivitiesMenu;
                default:
                    Console.WriteLine("Please enter a valid response!");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return MenuChoices.PassActivities;
            }
        }
    }
}