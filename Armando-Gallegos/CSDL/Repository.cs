using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using CSModels;

namespace CSDL
{
    //The repository has a bunch of methods that we will use to get or store information from
    //the DataBase.  It does not acturaly hold the data itself
    public class Repository : IRepository
    {
        //The relative path to the JSON
        private const string _filepath = "./../CSDL/JSON/";
        private string _jsonString;

        public Activity AddActivity(Activity p_act)
        {
            List<Activity> ListOfActivities = GetAllActivities();
            ListOfActivities.Add(p_act);
            _jsonString = JsonSerializer.Serialize(ListOfActivities, new JsonSerializerOptions{WriteIndented=true});
            File.WriteAllText(_filepath+"Activities.json",_jsonString);
            return p_act;
            
        }

        public Passenger AddPassenger(Passenger p_pass)
        {
            List<Passenger> ListOfPassengers = GetAllPassengers();
            ListOfPassengers.Add(p_pass);
            _jsonString = JsonSerializer.Serialize(ListOfPassengers, new JsonSerializerOptions{WriteIndented=true});
            File.WriteAllText(_filepath+"Passengers.json",_jsonString);
            return p_pass;
            
        }

        public Attendants AddAttendant(Attendants p_att)
        {
            List<Attendants> ListOfAttendants = GetAllAttendants();
            ListOfAttendants.Add(p_att);
            _jsonString = JsonSerializer.Serialize(ListOfAttendants, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filepath + "Attendants.json", _jsonString);
            return p_att;

        }

        public Restaurant AddRestaurant(Restaurant p_rest)
        {
            List<Restaurant> ListOfRestaurants = GetAllRestaurants();
            ListOfRestaurants.Add(p_rest);
            _jsonString = JsonSerializer.Serialize(ListOfRestaurants, new JsonSerializerOptions{WriteIndented=true});
            File.WriteAllText(_filepath+"Restaurants.json",_jsonString);
            return p_rest;
        } 

        public Activity RemoveActivity(Activity p_act)
        {
            List<Activity> ListOfActivities = GetAllActivities();
            ListOfActivities.Remove(p_act);
            _jsonString = JsonSerializer.Serialize(ListOfActivities, new JsonSerializerOptions{WriteIndented=true});
            File.WriteAllText(_filepath+"Activities.json",_jsonString);
            return p_act;
            
        }

        public Passenger RemovePassenger(Passenger p_pass)
        {
            List<Passenger> ListOfPassengers = GetAllPassengers();
            ListOfPassengers.Remove(p_pass);
            _jsonString = JsonSerializer.Serialize(ListOfPassengers, new JsonSerializerOptions{WriteIndented=true});
            File.WriteAllText(_filepath+"Passengers.json",_jsonString);
            return p_pass;
            
        }

        public Attendants RemoveAttendant(Attendants p_att)
        {
            List<Attendants> ListOfAttendants = GetAllAttendants();
            ListOfAttendants.Remove(p_att);
            _jsonString = JsonSerializer.Serialize(ListOfAttendants, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filepath + "Attendants.json", _jsonString);
            return p_att;

        }

        public Restaurant RemoveRestaurant(Restaurant p_rest)
        {
            List<Restaurant> ListOfRestaurants = GetAllRestaurants();
            ListOfRestaurants.Remove(p_rest);
            _jsonString = JsonSerializer.Serialize(ListOfRestaurants, new JsonSerializerOptions{WriteIndented=true});
            File.WriteAllText(_filepath+"Restaurants.json",_jsonString);
            return p_rest;
        } 

         public List<Activity> BookActivity(Activity p_act)
        {
            /// <summary>
            /// This is where the ship activities will be stored
            /// </summary>
            /// <returns></returns>
            _jsonString = File.ReadAllText(_filepath+"Reservations.json");

            //Converting from string(JSON) into an object
            return JsonSerializer.Deserialize<List<Activity>>(_jsonString);
        }

        public List<Activity> GetAllActivities()
        {
            /// <summary>
            /// This is where the ship activities will be stored
            /// </summary>
            /// <returns></returns>
            _jsonString = File.ReadAllText(_filepath+"Activities.json");

            //Converting from string(JSON) into an object
            return JsonSerializer.Deserialize<List<Activity>>(_jsonString);
        }

        public List<Passenger> GetAllPassengers()
        {
            /// <summary>
            /// This is where the ship activities will be stored
            /// </summary>
            /// <returns></returns>
            _jsonString = File.ReadAllText(_filepath+"Passengers.json");

            //Converting from string(JSON) into an object
            return JsonSerializer.Deserialize<List<Passenger>>(_jsonString);
        }
        public List<Attendants> GetAllAttendants()
        {
            /// <summary>
            /// This is where the ship activities will be stored
            /// </summary>
            /// <returns></returns>
            _jsonString = File.ReadAllText(_filepath + "Attendants.json");

            //Converting from string(JSON) into an object
            return JsonSerializer.Deserialize<List<Attendants>>(_jsonString);
        }

        public List<Restaurant> GetAllRestaurants()
        {
            /// <summary>
            /// This is where the list of all restaurants will be stored
            /// </summary>
            /// <returns></returns>
            _jsonString = File.ReadAllText(_filepath+"Restaurants.json");

            //Converting from string(JSON) into an object
            return JsonSerializer.Deserialize<List<Restaurant>>(_jsonString);
        }
        public List<Ship> GetAllShips()
        {
            /// <summary>
            /// This is where the ship activities will be stored
            /// </summary>
            /// <returns></returns>
            _jsonString = File.ReadAllText(_filepath+"Ships.json");

            //Converting from string(JSON) into an object
            return JsonSerializer.Deserialize<List<Ship>>(_jsonString);
        }
        public List<PassengerActivities> GetPassActivities(Passenger p_pass)
        {

            throw new NotImplementedException();
        }

        public Passenger GetPassengerByCNo(int cabin_no)
        {
            throw new NotImplementedException();
        }

        public Passenger GetPassengerbyCabNo(int cabin_no)
        {
            throw new NotImplementedException();
        }

        public Activity GetActivitybyId(int p_AId)
        {
            throw new NotImplementedException();
        }

        public Activity UpdateActivitySpots(Activity p_act)
        {
            throw new NotImplementedException();
        }
    }
}
