using System;
using System.Collections.Generic;
using CSModels;
using CSDL;

namespace CSBL
{
    public class AttendantBL : IAttendantBL
    {
        /// <summary>
        /// this is the dependency injection
        /// </summary>
        /// <returns></returns>
        private IRepository _repo;
        //GETTER
        public AttendantBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        //SETTER
        public List<Attendants> GetAllAttendants()
        {
            //This will capitalize all of the Names in the activities JSON
            List<Attendants> listOfAttendants = _repo.GetAllAttendants();
            for (int i = 0; i < listOfAttendants.Count; i++)
            {
                listOfAttendants[i].AttendantName = listOfAttendants[i].AttendantName.ToUpper();
            }
            return  listOfAttendants;
        }

        public Attendants AddAttendant(Attendants p_att)
        {
            return _repo.AddAttendant(p_att);
        }

     /*   public Attendants RemoveAttendant(Attendants p_att)
        {
            return _repo.RemoveAttendant(p_att);
        } */
    }
}