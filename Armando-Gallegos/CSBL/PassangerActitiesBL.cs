using System;
using System.Collections.Generic;
using CSModels;
using CSDL;

namespace CSBL
{
    public class PassengerActivitiesBL : IPassengerActivitiesBL
    {
        /// <summary>
        /// this is the dependency injection
        /// </summary>
        /// <returns></returns>
        private IRepository _repo;
        //GETTER
        public PassengerActivitiesBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        //SETTER
        public List<PassengerActivities> GetPassActivities(Passenger p_pass)
        {
            //This will capitalize all of the Names in the activities JSON
            List<PassengerActivities> listOfPassengerActivities = _repo.GetPassActivities(p_pass);
            for (int i = 0; i < listOfPassengerActivities.Count; i++)
            {
                listOfPassengerActivities[i].PName = listOfPassengerActivities[i].PName.ToUpper();
            }
            return  listOfPassengerActivities;
        }
    }
}