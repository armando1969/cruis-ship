using System;
using System.Collections.Generic;
using CSModels;
using CSBL;

namespace CSUI
{
    public class ShowRestaurants : ISMenu
    {
        private IRestaurantBL _restaurantBL;

        //Another dependency Injection
        public ShowRestaurants(IRestaurantBL p_restauranteBL)
        {
            _restaurantBL = p_restauranteBL;
        }
        public MenuChoices UserChoice()
        {
            string RestaurantChoice = Console.ReadLine();
            switch (RestaurantChoice)
            {
                case "0":
                    return MenuChoices.ActivitiesMenu1;
                default:
                    Console.WriteLine("Please enter a valid response!");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return MenuChoices.ShowRestaurants;
            }
        }

        public void Menu()
        {
            Console.WriteLine("List of Restaurants");
            List<Restaurant> listOfRestaurants = _restaurantBL.GetAllRestaurants();
            foreach (Restaurant rest in listOfRestaurants)
            {
                Console.WriteLine("================");
                Console.WriteLine(rest);
                Console.WriteLine("=================");
            }
            Console.WriteLine("[0] - Go Back");
        }
    }
}