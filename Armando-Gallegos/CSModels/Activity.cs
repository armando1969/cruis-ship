using System;
using System.Text.RegularExpressions;


namespace CSModels
{
    public class Activity
    {
        private int _aShip;

        private string _activityName;

        private int _aId;

        private string _activityDescription;

        private string _activityInstructor;

        private int _aSpots;

        public int AShip
        {
            get { return _aShip; }
            set
            {
                _aShip = value;
            }
        }
        public string AName
        {
             get {return _activityName;}
             set {
                 if (!Regex.IsMatch(value, @"^[A-Za-z .,]+$"))
                 {

                     throw new Exception("Activity Name can only be Alphabetic!");

                 }
                _activityName = value;
             }
        }
         public int AId 
        {
             get {return _aId;}
             set {
                _aId = value;
                }
        }
        public string ADescription
        {
            
             get {return _activityDescription;}
             set {
                 if (!Regex.IsMatch(value, @"^[A-Za-z .,']+$"))
                 {

                     throw new Exception("Activity description can only be Alphabetic!");

                 }
                _activityDescription = value;
             }
        }

        public string AAttendant
        {
             get {return _activityInstructor;}
             set {
                 if (!Regex.IsMatch(value, @"^[A-Za-z .,]+$"))
                 {

                     throw new Exception("Activity Name can only be Alphabetic!");

                 }
                _activityInstructor = value;
             }
        }

        public int ASpots
        {
            get { return _aSpots; }
            set
            {
                _aSpots = value;
            }
        }

        public override string ToString()
        {
            return $"Activity Id: {AId}\nActivity Name: {AName}\nActivity Attendant: {AAttendant}\nSpots Available: {ASpots}";
        }
    }
}