using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CSModels
{
    public class Attendants
    {
        private int _attShip;
        private  string _attName;
        private int _attId;
        private string _attSpeciality;

        public int AttShip
        {
            get { return _attShip; }
            set { _attShip = value; }
        }
        public string AttendantName 
        { 
            get
            {
                return _attName;
            } 
             set {
                 if (!Regex.IsMatch(value, @"^[A-Za-z .,]+$"))
                 {
                     throw new Exception("Attendant's Name can only be Alphabetic!");

                 }
                _attName = value;
             }
        }
        public int AttId 
        { 
            get{ return _attId; } 
            set{ _attId = value; }
        }
        public string AttSpecialties 
        { 
            get {return _attSpeciality;}
             set {
                 if (!Regex.IsMatch(value, @"^[A-Za-z .,]+$"))
                 {
                     throw new Exception("Passanger Name can only be Alphabetic!");

                 }
                _attSpeciality = value;
             }
        }
        
         public override string ToString()
        {
            return $"Attendant Id: {AttId}\nAttendant Name: {AttendantName}\n Attendant Speciality: {AttSpecialties}";
        }
        
    }
}