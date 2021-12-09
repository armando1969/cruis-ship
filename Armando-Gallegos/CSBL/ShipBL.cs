using System;
using System.Collections.Generic;
using CSModels;
using CSDL;

namespace CSBL
{ 
    public class ShipBL : IShipBL
    {
        /// <summary>
        /// this is the dependency injection
        /// </summary>
        /// <returns></returns>
        private IRepository _repo;
        //GETTER
        public ShipBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        //SETTER
        public List<Ship> GetAllShips()
        {
             //This will capitalize all of the Names in the activities JSON
            List<Ship> listOfShips = _repo.GetAllShips();
            for (int i = 0; i < listOfShips.Count; i++)
            {
                listOfShips[i].SName = listOfShips[i].SName.ToUpper();
            }
            return  listOfShips;
        }

     /*   public Ship AddShip(Ship p_ship)
        {
            return _repo.AddShip(p_ship);
        }*/
    }
}