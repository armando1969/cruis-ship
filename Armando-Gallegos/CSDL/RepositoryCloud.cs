using Model = CSModels;
using System.Collections.Generic;
using Entity = CSDL.Entities;
using System.Linq;
using CSModels;
using Microsoft.EntityFrameworkCore;

namespace CSDL
{

    public class RepositoryCloud : IRepository
    {

        private Entity._211004revatureagdemodbContext _context;
        public RepositoryCloud(Entity._211004revatureagdemodbContext p_context)
        {
            _context = p_context;
        }
            public Model.Activity AddActivity(Model.Activity p_act)
            {
                _context.Activities.Add
                (
                    new Entity.Activity()
                    {
                        AShip = p_act.AShip,
                        AName = p_act.AName,
                        ADescription = p_act.ADescription,
                        AInstructor = p_act.AAttendant,
                        ASpots = p_act.ASpots
                    }
                );
                _context.SaveChanges();
                return p_act;
        }

        public Model.Passenger AddPassenger(Model.Passenger p_pass)
        {
            _context.Passangers.Add
            (
                new Entity.Passanger()
                {
                    PShip = p_pass.PShip,
                    PName = p_pass.PName,
                    PClass = p_pass.PClass
                }
            );

            _context.SaveChanges();
            return p_pass;
        }

        public Model.Attendants AddAttendant(Model.Attendants p_att)
        {
            _context.Attendants.Add
            (
                new Entity.Attendant()
                {
                    AttShip = p_att.AttShip,
                    AttName = p_att.AttendantName,
                    AttSpecialties = p_att.AttSpecialties
                }
            );

            _context.SaveChanges();
            return p_att;
        }

        public Model.Restaurant AddRestaurant(Model.Restaurant p_rest)
        {
            _context.Restaurants.Add
           (
               new Entity.Restaurant()
               {
                   RShip = p_rest.RShip,
                   RName = p_rest.RName,
                   RDescription = p_rest.RDescription,
                   RTables = p_rest.NofTables
               }
           );

            _context.SaveChanges();
            return p_rest;
        }

        public List<Model.Activity> BookActivity(Model.Activity p_act)
        {
            throw new System.NotImplementedException();
        }

        public List<Model.Activity> GetAllActivities()
        {

            return _context.Activities.Select(act =>
                new Model.Activity()
                {
                    AId = act.AId,
                    AName = act.AName,
                    ADescription = act.ADescription,
                    AAttendant = act.AInstructor,
                    ASpots = act.ASpots
                }

            ).ToList();
        }

        public List<Model.Passenger> GetAllPassengers()
        {
            return _context.Passangers.Select(pass =>
                new Model.Passenger()
                { 
                    CabinNo = pass.CabinNo,
                    PName = pass.PName,
                    PClass = pass.PClass
                }
            
            ).ToList();

            /*var result = (from pass in _context.Passangers
                            select pass);
            List<Model.Passenger> listofPass = new List<Model.Passenger>();
            foreach (var pass in result)
            {
                listofPass.Add(new Model.Passenger()
                {
                    PName = pass.PName,
                    CabinNo = pass.CabinNo
                });
            }
            return listofPass;*/
        }

        public List<Model.Attendants> GetAllAttendants()
        {
            return _context.Attendants.Select(att =>
                new Model.Attendants()
                {
                    AttId = att.AttId,
                    AttendantName = att.AttName,
                    AttSpecialties = att.AttSpecialties
                }

            ).ToList();

        }

        public List<Model.Restaurant> GetAllRestaurants()
        {
            return _context.Restaurants.Select(rest =>
                new Model.Restaurant()
                {
                    RId = rest.RId,
                    RName = rest.RName,
                    RDescription = rest.RDescription,
                    NofTables = rest.RTables
                }

            ).ToList();
        }
         public List<Model.Ship> GetAllShips()
        {

            return _context.Ships.Select(ship =>
                new Model.Ship()
                {
                    SName = ship.ShipName
                }

            ).ToList();
        }

        public List<Model.PassengerActivities> GetPassActivities(Model.Passenger p_pass)
        {
            //querry syntax
            var result = (from passact in _context.PassangerActivities
                          where passact.PcabinNo == p_pass.CabinNo
                          select passact);

            //Mapping the entity List from Entity to Model
            List<Model.PassengerActivities> listOfPActivities = new List<Model.PassengerActivities>();

            foreach (Entity.PassangerActivity passact in result)
            {
                listOfPActivities.Add(new Model.PassengerActivities()
                {
                    PName = passact.PassName,
                    AIdNo = passact.AIdNo,
                    CNo = passact.PcabinNo
                });
            }
            return listOfPActivities;
        }
         public Model.Passenger GetPassengerbyCabNo(int cabin_no)
        {
            Entity.Passanger passSearch = _context.Passangers.Find(cabin_no);
            return new Model.Passenger()
            {
                CabinNo = passSearch.CabinNo,
                PName = passSearch.PName,
                PClass = passSearch.PClass
            };
        }

        public Model.Activity GetActivitybyId(int p_AId)
        {
            Entity.Activity actFound = _context.Activities.AsNoTracking().FirstOrDefault(act => act.AId == p_AId);

            return new Model.Activity()
            {
                AId = actFound.AId,
                AName = actFound.AName,
                ADescription = actFound.ADescription,
                AAttendant = actFound.AInstructor,
                ASpots = actFound.ASpots

            };
        }

        public Activity UpdateActivitySpots(Activity p_act)
        {
            Entity.Activity actChanged = new Entity.Activity()
            {
                AId = p_act.AId,
                AName = p_act.AName,
                ADescription = p_act.ADescription,
                AInstructor = p_act.AAttendant,
                ASpots = p_act.ASpots,
                AShip = p_act.AShip
            };

            _context.Activities.Update(actChanged);

            _context.SaveChanges();

            return p_act;
        }
    }
}
