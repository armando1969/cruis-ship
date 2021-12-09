namespace CSUI
{
    public enum MenuChoices
    {
        MainMenu,
        ListActivities,
        ActivitiesMenu1,
        ActivitiesMenu2,
        ActivitiesMenu3,
        RestaurantMenu,
        ShowActivities,
        BookActivity,
        ShowRestaurants,
        SearchActivitiesMenu,
        ShowPassengers,
        SearchPassbyName,
        SearchPassbyCabNo,
        PassActivitesAdmin,
        PassActivities,
        BookRestaurant,
        AdminMenu,
        AddPassanger,
        AddAttendant,
        AddRestaurant,
        AddActivity,
        Exit
    }

    //This will create the menus for our project
    public interface ISMenu
    {
        /// <summary>
        /// Will Display the main menu options
        /// </summary>
        void Menu();

        MenuChoices UserChoice();
      //  AdminMenuChoices AdminChoices();

    }

}