using System.Collections.Generic;
using CSModels;

namespace CSDL
{
/// <summary>
/// We are adding to our JSON repositories
/// </summary>
    public interface IRepository
    {
        /// <summary>
        /// This is a replication of the add get funtions in our repository class
        /// </summary>
        /// <returns></returns>
        
        Activity AddActivity(Activity p_act);

        Passenger AddPassenger(Passenger p_pass);

        Attendants AddAttendant(Attendants p_att);

        Restaurant AddRestaurant(Restaurant p_rest);

      /*  Activity RemoveActivity(Activity p_act);

        Passenger RemovePassenger(Passenger p_pass);

        Attendants RemoveAttendant(Attendants p_att);

        Restaurant RemoveRestaurant(Restaurant p_rest);*/

        List<Activity> BookActivity(Activity p_act);
        List<Activity> GetAllActivities();
        List<Passenger> GetAllPassengers();
        List<Attendants> GetAllAttendants();
        List<Restaurant> GetAllRestaurants();
        List<Ship> GetAllShips();
        List<PassengerActivities> GetPassActivities(Passenger p_pass);

        Passenger GetPassengerbyCabNo(int cabin_no);

        Activity GetActivitybyId(int p_AId);

        Activity UpdateActivitySpots(Activity p_act);

       // List<PassengerActivities> GetAPassanger(Passenger p_act);
    }
}