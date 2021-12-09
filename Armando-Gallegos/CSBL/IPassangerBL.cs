using System.Collections.Generic;
using CSModels;
/// <summary>
///
/// </summary>
namespace CSBL 
{
    public interface IPassengerBL
    {
        /// <summary>
        /// This returns the lists stored in the JSON's
        /// </summary>
        /// <returns></returns>
        List<Passenger> GetAllPassengers();
        List<Passenger> GetPassenger(string p_name);
        List<PassengerActivities> GetPassActivities(Passenger p_pass);
        Passenger GetPassengerbyCabNo(int CabNo);
        Passenger AddPassenger(Passenger p_pass);
     //   Passenger RemovePassenger(Passenger p_pass);

    }
}