using System;
using CSBL;
using CSModels;

namespace CSUI
{
    public class AddAttendant :ISMenu
    {
        private static Attendants _att = new Attendants();
        private IAttendantBL _attBL;

        public AddAttendant(IAttendantBL p_attBL)
        {
            _attBL = p_attBL;
        }
        public void Menu()
        {
            bool correct = false;
            string answer;
            while(!correct)
            {
                Console.WriteLine("Adding a new Attendant");
                _att.AttShip = 1;
                Console.Write("Attendant Name: ");
                _att.AttendantName = Console.ReadLine();
                Console.Write("Attendant Specialty: ");
                _att.AttSpecialties = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You have entered:");
                Console.WriteLine("================");
                Console.WriteLine("Attendant Name: " + _att.AttendantName);
                Console.WriteLine("Attendant's Speciality: " + _att.AttSpecialties);
                Console.WriteLine("=================");
                Console.WriteLine("Is this Correct?");
                Console.WriteLine("Enter [Y] for Yes or [N] to re enter the Activity Info.");
                answer = Console.ReadLine();
                if(answer == "Y")
                {
                    correct = true;
                    _attBL.AddAttendant(_att);
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