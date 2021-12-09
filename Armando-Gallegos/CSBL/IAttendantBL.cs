using System.Collections.Generic;
using CSModels;
/// <summary>
///
/// </summary>
namespace CSBL
{
    public interface IAttendantBL
    {
        /// <summary>
        /// This returns the lists stored in the JSON's
        /// </summary>
        /// <returns></returns>
        List<Attendants> GetAllAttendants();

        Attendants AddAttendant(Attendants p_att);

     //   Attendants RemoveAttendant(Attendants p_att);

    }
}