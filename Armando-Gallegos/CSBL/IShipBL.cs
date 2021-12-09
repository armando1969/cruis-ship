using System.Collections.Generic;
using CSModels;
/// <summary>
///
/// </summary>
namespace CSBL 
{
    public interface IShipBL
    {
        /// <summary>
        /// This returns the lists stored in the JSON's
        /// </summary>
        /// <returns></returns>
        List<Ship> GetAllShips();
    //    Restaurant AddRestaurant(Restaurant p_rest);

    //    Restaurant RemoveRestaurant(Restaurant p_rest);

    }
}