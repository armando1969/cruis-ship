using System;
using System.Collections.Generic;
using CSModels;

namespace CSUI
{
    public class RestaurantMenu : ISMenu
    {
        public MenuChoices UserChoice()
        {
            string RestaurantChoice = Console.ReadLine();
            switch(RestaurantChoice)
            {
                    case "2":
                        return MenuChoices.ShowRestaurants;
                    case "1":
                        return MenuChoices.BookRestaurant;
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
                Console.WriteLine("Welcome to the Ships Activities Menu");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("[2] - List all of the Restaurants on ship");
                Console.WriteLine("[1] - Book a table at your Restaurant");
                Console.WriteLine("[0] - Return to the Main Menu");
            }
    }
}