using System;
using CSBL;
using CSModels;

namespace CSUI
{
    public class AddRestaurant :ISMenu
    {
        private static Restaurant _rest = new Restaurant();
        private IRestaurantBL _restBL;

        public AddRestaurant(IRestaurantBL p_restBL)
        {
            _restBL = p_restBL;
        }
        public void Menu()
        {
            bool correct = false;
            string answer;
            while(!correct)
            {
                Console.WriteLine("Adding a new Restaurant");
                _rest.RShip = 1;
                Console.Write("Restaurant Name: ");
                _rest.RName = Console.ReadLine();
                Console.Write("Restaurant Description: ");
                _rest.RDescription = Console.ReadLine();
                Console.Write("No of Tables at a Restaurant: ");
                _rest.NofTables = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("You have entered:");
                Console.WriteLine("================");
                Console.WriteLine("Restaurant Name: " + _rest.RName);
                Console.WriteLine("Restaurant Description: " + _rest.RDescription);
                Console.WriteLine("Restaurant Tables Available: " + _rest.NofTables);
                Console.WriteLine("=================");
                Console.WriteLine("Is this Correct?");
                Console.WriteLine("Enter [Y] for Yes or [N] to re enter the Restaurant Info.");
                answer = Console.ReadLine();
                if(answer == "Y")
                {
                    correct = true;
                    _restBL.AddRestaurant(_rest);
                }
                else 
                    Console.Clear();
            }
        }
        
        public MenuChoices UserChoice()
        {
            return MenuChoices.AdminMenu;
        }
    }
}  