using CSBL;
using CSModels;
using System;
using System.Collections.Generic;

namespace CSUI
{
    public class PassActiviesAdmin : ISMenu
    {
        private IPassengerBL _passBL;

        public PassActiviesAdmin(IPassengerBL p_passBL)
        {
            this._passBL = p_passBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of Activities");
            List<PassengerActivities> listOfActivities = _passBL.GetPassActivities(ShowPassengers._findPass);

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
                    return MenuChoices.ShowPassengers;
                default:
                    Console.WriteLine("Please enter a valid response!");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return MenuChoices.PassActivitesAdmin;
            }
        }
    }
}