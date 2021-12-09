using System;
using System.Collections.Generic;
using CSModels;
using CSDL;

namespace CSBL
{ 
    public class RestaurantBL : IRestaurantBL
    {
        /// <summary>
        /// this is the dependency injection
        /// </summary>
        /// <returns></returns>
        private IRepository _repo;
        //GETTER
        public RestaurantBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        //SETTER
        public List<Restaurant> GetAllRestaurants()
        {
             //This will capitalize all of the Names in the activities JSON
            List<Restaurant> listOfRestaurants = _repo.GetAllRestaurants();
            for (int i = 0; i < listOfRestaurants.Count; i++)
            {
                listOfRestaurants[i].RName = listOfRestaurants[i].RName.ToUpper();
            }
            return  listOfRestaurants;
        }

        public Restaurant AddRestaurant(Restaurant p_rest)
        {
            return _repo.AddRestaurant(p_rest);
        }

    /*    public Restaurant RemoveRestaurant(Restaurant p_rest)
        {
            return _repo.RemoveRestaurant(p_rest);
        } */
    }
}