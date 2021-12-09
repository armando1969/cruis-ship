using System;
using CSBL;
using CSModels;

namespace CSUI
{
    public class AddPassenger :ISMenu
    {
        private static Passenger _pass = new Passenger();
        private IPassengerBL _passBL;

        public AddPassenger(IPassengerBL p_passBL)
        {
            _passBL = p_passBL;
        }
        public void Menu()
        {
            bool correct = false;
            string answer;
            while(!correct)
            {
                Console.WriteLine("Adding a new Passenger");
                _pass.PShip = 1;
                Console.Write("Passenger Name: ");
                _pass.PName = Console.ReadLine();
                Console.Write("Passenger's Class: ");
                _pass.PClass = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You have entered:");
                Console.WriteLine("================");
                Console.WriteLine("Passenger Name: " + _pass.PName);
                Console.WriteLine("Passanger's Class: " + _pass.PClass);
                Console.WriteLine("=================");
                Console.WriteLine("Is this Correct?");
                Console.WriteLine("Enter [Y] for Yes or [N] to re enter the Activity Info.");
                answer = Console.ReadLine();
                if(answer == "Y")
                {
                    correct = true;
                    _passBL.AddPassenger(_pass);
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