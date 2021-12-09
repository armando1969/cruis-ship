using System;
using System.Text.RegularExpressions;

namespace CSModels
{
    public class Restaurant
    {
        private int _restShip;
        private string _restName;
        private int _rId;
        private string _restDescription;
        private int _noOfTables;

        public int RShip
        {
            get { return _restShip; }
            set
            {
                _restShip = value;
            }
        }
        public string RName
        {
             get {return _restName;}
             set {
                 if (!Regex.IsMatch(value, @"^[A-Za-z .,']+$"))
                 {

                     throw new Exception("Activity Name can only be Alphabetic!");

                 }
                _restName = value;
             }
        }
         public int RId 
        {
             get {return _rId;}
             set {
                _rId = value;
                }
        }
        public string RDescription
        {
            
             get {return _restDescription;}
             set {
                 if (!Regex.IsMatch(value, @"^[A-Za-z .,']+$"))
                 {
                     throw new Exception("Activity Name can only be Alphabetic!");

                 }
                _restDescription = value;
             }
        }
        public int NofTables
        {
            get { return _noOfTables; }
            set
            {
                _noOfTables = value;
            }
        }

        public override string ToString()
        {
            return $"Restaurant ID:{RId}\n Name of Restaurant: {RName}\nDescription: {RDescription}\nTables Available: {NofTables}";
        }
    }
}