using System;
using System.Collections.Generic;
using CSModels;
using CSBL;

namespace CSUI
{
    public class ShowActivities : ISMenu
    {
        private IActivityBL _actBL;

        //Another dependency Injection
        public ShowActivities(IActivityBL p_actBL)
        {
            _actBL = p_actBL;
        }

        public MenuChoices UserChoice()
        {
            string ActivityChoice = Console.ReadLine();
            switch(ActivityChoice)
            {
                    case "0":
                        return MenuChoices.AdminMenu;
                    case "1":
                        Console.WriteLine("Enter the Id No of the Activity you want to Add spots from.");
                        try
                        {
                             int actId = Int32.Parse(Console.ReadLine());
                             Activity actFound = _actBL.GetActivitybyId(actId);
                             Console.WriteLine("Input how many spots you want to add to Activity");
                             int spotsAdded = Int32.Parse(Console.ReadLine());   
                             _actBL.UpdateActivity(actFound, spotsAdded);                     }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("Please input a numeric value!");
                            Console.WriteLine("Please enter to continue");
                            Console.ReadLine();
                            return MenuChoices.ShowActivities;
                        }
                        return MenuChoices.ShowActivities;
                    default:
                        Console.WriteLine("Please enter a valid response!");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        return MenuChoices.ShowActivities;
            }
        }

        public void Menu()
        {
            Console.WriteLine("List of Activities");
            List<Activity>listOfActivities = _actBL.GetAllActivities();
            foreach (Activity act in listOfActivities)
            {
                Console.WriteLine("================");
                Console.WriteLine(act);
                Console.WriteLine("=================");
            }
            Console.WriteLine("[1] - Select an Activity by Id");
            Console.WriteLine("[0] - Go Back");
        }
    }
}