using System;
using System.Collections.Generic;
using CSModels;
using CSDL;
using System.Linq;

namespace CSBL
{
    public class PassengerBL : IPassengerBL
    {
        /// <summary>
        /// this is the dependency injection
        /// </summary>
        /// <returns></returns>
        private IRepository _repo;
        //GETTER
        public PassengerBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        //SETTER
        public List<Passenger> GetAllPassengers()
        {
            //This will capitalize all of the Names in the activities JSON
            List<Passenger> listOfPassengers = _repo.GetAllPassengers();
            for (int i = 0; i < listOfPassengers.Count; i++)
            {
                listOfPassengers[i].PName = listOfPassengers[i].PName.ToUpper();
            }
            return  listOfPassengers;
        }

        public List<Passenger> GetPassenger(string p_name)
        {
            List<Passenger> listOfPassenger = _repo.GetAllPassengers();

            return listOfPassenger.Where(pass => pass.PName.ToLower().Contains(p_name.ToLower())).ToList();
        }

        public Passenger GetPassengerbyCabNo(int CabNo)
        {
            //This will capitalize all of the Names in the activities JSON
            Passenger passFound = _repo.GetPassengerbyCabNo(CabNo);

           // Restaurant restFound = _repo.GetRestaurantById(p_Id);

            if (passFound == null)
            {
                throw new Exception("Restaurant was not found!");
            }

            return passFound;
           // return passFound.Where(passFound => passFound.CabinNo.Equals(CabNo));
            /*{
                if (passFound => passFound.CabinNo.Equals(CabNo) == null)
                {
                    throw new Exception("Passanger was not found");
                }
            })
            return passFound;*/
        }

        public List<PassengerActivities> GetPassActivities(Passenger p_pass)
        {
            return _repo.GetPassActivities(p_pass);
        }

        public Passenger AddPassenger(Passenger p_pass)
        {
            return _repo.AddPassenger(p_pass);
        }
    }
}