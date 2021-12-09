using System.Collections.Generic;
using CSModels;
/// <summary>
///
/// </summary>
namespace CSBL 
{
    public interface IActivityBL
    {
        /// <summary>
        /// This returns the lists stored in the JSON's
        /// </summary>
        /// <returns></returns>
        List<Activity> GetAllActivities();

       // List<Activity> BookActivity(Activity p_act);

        Activity AddActivity(Activity p_act);

        Activity GetActivitybyId(int p_AId);

        Activity UpdateActivity(Activity p_act, int p_changed);

      //  Activity RemoveActivity(Activity p_act);

    }
}