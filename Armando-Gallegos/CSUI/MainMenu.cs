using CSModels;
using CSBL;
using System;
using System.Collections.Generic;

namespace CSUI
{

    public class MainMenu : ISMenu
    {
      //  private IShipBL _shipBL;

    /*    public MainMenu(IShipBL p_shipBL)
        {
            _shipBL = p_shipBL;
        }*/

        public MenuChoices UserChoice()
        { 
            string MainChoice = Console.ReadLine();
           // List<Ship> listOfShips = _shipBL.GetAllShips();
            switch(MainChoice)
            {
                case "1":
                    return MenuChoices.ActivitiesMenu1;
                case "2":
                    return MenuChoices.ActivitiesMenu2;
                case "3":
                    return MenuChoices.ActivitiesMenu3;
                case "0":
                    return MenuChoices.Exit;
                case "X":
                    return MenuChoices.AdminMenu;
                default:
                    Console.WriteLine("Please enter a valid response!");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return MenuChoices.MainMenu;
            }
        }
        public void Menu()
        {
          //  List<Ship> listOfShips = _shipBL.GetAllShips();
            Console.WriteLine("Welcome to the Houston Shipline");
            Console.WriteLine("Chose your ship");
            Console.WriteLine("[3] - Star of The North"/*+istOfShips[0].SName*/);
            Console.WriteLine("[2] - Houston Steamer"/*+listOfShips[1].SName*/);
            Console.WriteLine("[1] - Buffalo Bayou Liner"/*+listOfShips[2].SName*/);
            Console.WriteLine("[0] - Exit");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("[X] - Admin Menu");
        }
    }
   
}