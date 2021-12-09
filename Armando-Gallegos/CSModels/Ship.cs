using System;
using System.Text.RegularExpressions;


namespace CSModels
{
    public class Ship
    {
        private string _shipName;

        public string SName
        {
             get {return _shipName;}
             set {
                 if (!Regex.IsMatch(value, @"^[A-Za-z .,]+$"))
                 {

                     throw new Exception("Ship's Name can only be Alphabetic!");

                 }
                _shipName = value;
             }
        }

        public override string ToString()
        {
            return $"Ship's Name: {SName}";
        }
    }
}