using System.Collections.Generic;
using CSModels;
/// <summary>
///
/// </summary>
namespace CSBL 
{
    public interface IPassengerActivitiesBL
    {
        /// <summary>
        /// This returns the lists stored in the JSON's
        /// </summary>
        /// <returns></returns>
        List<PassengerActivities> GetPassActivities(Passenger p_pass);

     //   Passenger AddPassActivity(Passenger p_pass);

    }
}