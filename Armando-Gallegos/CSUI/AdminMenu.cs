using System;

namespace CSUI
{

    public class AdminMenu : ISMenu
    {
         public MenuChoices UserChoice()
        {
            string MainChoice = Console.ReadLine();
            switch(MainChoice)
            {
                case "1":
                    return MenuChoices.ShowActivities;
                case "2":
                    return MenuChoices.ShowPassengers;
                case "3":
                    return MenuChoices.AddPassanger;
                case "4":
                    return MenuChoices.AddActivity;
             //   case "5":
             //       return MenuChoices.AddRestaurant;
                case "5":
                    return MenuChoices.AddAttendant;
                case "0":
                    return MenuChoices.MainMenu;
                default:
                    Console.WriteLine("Please enter a valid response!");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return MenuChoices.AdminMenu;
            }
        }

        public void Menu()
        {
            Console.WriteLine("This is the Administror's Access Menu");
            Console.WriteLine("Access restricted to Authorized Crew Members");
            Console.WriteLine("[5] - Add Attendants");
       //     Console.WriteLine("[5] - Add/Reserve Restaurant");
            Console.WriteLine("[4] - Add Activies");
            Console.WriteLine("[3] - Add Passangers");
            Console.WriteLine("[2] - Show Ships Passengers");
            Console.WriteLine("[1] - Show Ships Activities");
            Console.WriteLine("[0] - Return to the Main");
        }
    }
   
}