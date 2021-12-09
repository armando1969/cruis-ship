using System;

namespace CSUI
{
     public class ActivitiesMenu : ISMenu
    {
        private string _shipsName;

        public ActivitiesMenu(string p_shipsName)
        {
            _shipsName = p_shipsName;
        }
        public MenuChoices UserChoice()
        {
            string ActivityChoice = Console.ReadLine();
            switch(ActivityChoice)
            {
                    case "3":
                        return MenuChoices.ShowActivities;
                    case "2":
                        return MenuChoices.SearchActivitiesMenu;
                    case "1":
                        return MenuChoices.BookActivity;
                    case "0":
                        return MenuChoices.MainMenu;
                    default:
                        Console.WriteLine("Please enter a valid response!");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        return MenuChoices.MainMenu;
            }
        }
        public void Menu()
            {
                Console.WriteLine("Welcome to the " + _shipsName + " Activities Menu");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("[3] - List all Ship Board Activities");
                Console.WriteLine("[2] - List all of of your Activities");
                Console.WriteLine("[1] - Book an activity");
             //   Console.WriteLine("[1] - Book a table at your Restaurant");
                Console.WriteLine("[0] - Return to the Main Menu");
            }
    }  
}