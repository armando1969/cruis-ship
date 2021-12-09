using System.IO;
using Microsoft.Extensions.Configuration;
using System;
using CSModels;
using CSBL;
using CSDL;
using Microsoft.EntityFrameworkCore;
using CSDL.Entities;

namespace CSUI
{
    class SUI
    {
        static void Main(string[] args)
        {
            Passenger Cust = new Passenger();
            Attendant Emp = new Attendant();
            //I had Menu instead of MainMenu but it gave me a syntax error
            //MainMenu Men = new MainMenu(); 

            bool repeat = true;
            ISMenu page = new MainMenu();
            

            while (repeat)
            {
                Console.Clear();
                page.Menu();
                var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsetting.JSON")
                    .Build();

                DbContextOptions<_211004revatureagdemodbContext> opts = new DbContextOptionsBuilder<_211004revatureagdemodbContext>()
                .UseSqlServer(config.GetConnectionString("projectdb"))
                .Options;

                MenuChoices choice = page.UserChoice();
                switch (choice)
                {
                    case MenuChoices.MainMenu:
                        page = new MainMenu();
                        break;
                    case MenuChoices.ActivitiesMenu1:
                        page = new ActivitiesMenu("BUFALO BAYOU LINER");
                        break;
                    case MenuChoices.ActivitiesMenu2:
                        page = new ActivitiesMenu("HOUSTON STEAMER");
                        break;
                    case MenuChoices.ActivitiesMenu3:
                        page = new ActivitiesMenu("STAR OF THE NORTH");
                        break;
               //     case MenuChoices.RestaurantMenu:
               //         page = new RestaurantMenu();
               //         break;
                    case MenuChoices.AddActivity:
                        page = new AddActivity(new ActivityBL(new RepositoryCloud(new _211004revatureagdemodbContext(opts))));
                        break;
                   // case MenuChoices.BookActivity:
                  //      page = new BookActivity(new ActivityBL(new RepositoryCloud(new _211004revatureagdemodbContext(opts))));
                        //break;
                //    case MenuChoices.AddRestaurant:
                //        page = new AddRestaurant(new RestaurantBL(new RepositoryCloud(new _211004revatureagdemodbContext(opts))));
               //         break;
                     case MenuChoices.AddPassanger:
                        page = new AddPassenger(new PassengerBL(new RepositoryCloud(new _211004revatureagdemodbContext(opts))));
                        break;
                    case MenuChoices.AddAttendant:
                        page = new AddAttendant(new AttendantBL(new RepositoryCloud(new _211004revatureagdemodbContext(opts))));
                        break;
                    case MenuChoices.ShowActivities:
                        page = new ShowActivities(new ActivityBL(new RepositoryCloud(new _211004revatureagdemodbContext(opts))));
                        break;
                 //   case MenuChoices.ShowRestaurants:
                 //       page = new ShowRestaurants(new RestaurantBL(new RepositoryCloud(new _211004revatureagdemodbContext(opts))));
                //        break;
                    case MenuChoices.ShowPassengers:
                        page = new ShowPassengers(new PassengerBL(new RepositoryCloud(new _211004revatureagdemodbContext(opts))));
                        break;
                    case MenuChoices.SearchPassbyName:
                        page = new SearchPassbyName(new PassengerBL(new RepositoryCloud(new _211004revatureagdemodbContext(opts))));
                        break;
                    case MenuChoices.SearchActivitiesMenu:
                        page = new SearchActivitiesMenu(new PassengerBL(new RepositoryCloud(new _211004revatureagdemodbContext(opts))));
                        break;
                   // case MenuChoices.SearchPassbyCabNo:
                   //     page = new SearchPassbyCabNo(new PassengerBL(new RepositoryCloud(new _211004revatureagdemodbContext(opts))));
                   //     break;
                    case MenuChoices.PassActivitesAdmin:
                        page = new PassActiviesAdmin(new PassengerBL(new RepositoryCloud(new _211004revatureagdemodbContext(opts))));
                        break;
                    case MenuChoices.PassActivities:
                        page = new PassActivies(new PassengerBL(new RepositoryCloud(new _211004revatureagdemodbContext(opts))));
                        break;
                    case MenuChoices.AdminMenu:
                        page = new AdminMenu();
                        break;
                    case MenuChoices.Exit:
                        Console.WriteLine("You are exiting the application");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Coder you forgot yo write a menu option catch");
                        break;
                }
                
            }
        }
    }
}
