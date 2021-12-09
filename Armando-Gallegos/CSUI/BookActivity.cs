/*using System;
using CSBL;
using CSModels;

namespace CSUI
{
    public class BookActivity :ISMenu
    {
        private static Activity _act = new Activity();
        private IActivityBL _actBL;

        public BookActivity(IActivityBL p_actBL)
        {
            _actBL = p_actBL;
        }
        public void Menu()
        {
            bool correct = false;
            string answer;
            //string name;

            while(!correct)
            {
                Console.WriteLine("Book an  Activity");
                Console.Write("Please Enter the Name of the Activity you wish to book: ");
               /* name = Console.ReadLine();
                Console.WriteLine(name); // _act.AName = name;
                var _actSearch = _act.Find(x => x.AName == name); //end of first block out here
                Console.WriteLine("The Activities that match your request:");
                Console.WriteLine("================");
                Console.WriteLine("Activity Name: " + _act.AName);
                Console.WriteLine("Activity Description: " + _act.ADescription);
                Console.WriteLine("=================");
                Console.WriteLine("Is this Correct?");
                Console.WriteLine("Enter [Y] for Yes or [N] to re enter the Activity Info.");
                answer = Console.ReadLine();
                if(answer == "Y")
                {
                    correct = true;
                    _actBL.BookActivity(_act);
                }
                else 
                    Console.Clear();
            }
        }
        
        public MenuChoices UserChoice()
        {
            return MenuChoices.ActivitiesMenu;
        }
    }
}  */