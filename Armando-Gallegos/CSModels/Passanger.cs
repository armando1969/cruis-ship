using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace CSModels
{
    public class Passenger
    {
        private int _passShip;
        private string _passangerName;
        private string _passangerClass;
        private int _cabinNo;

        public int PShip
        {
            get { return _passShip; }
            set
            {
                _passShip = value;
            }
        }

        public string PName
        {
             get {return _passangerName;}
             set {
                 if (!Regex.IsMatch(value, @"^[A-Za-z .,]+$"))
                 {
                     throw new Exception("Passanger Name can only be Alphabetic!");

                 }
                _passangerName = value;
             }
        }

        public string PClass
        {
            get { return _passangerClass; }
            set
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .,0-9, ']+$"))
                {
                    throw new Exception("Passangers class has to be alpha-numeric!");

                }
                _passangerClass = value;
            }
        }

        public int CabinNo 
        {
             get {return _cabinNo;}
             set {
                _cabinNo = value;
                }
        }

         public override string ToString()
        {
            return $"Cabin No.: {CabinNo}\nName of Passanger: {PName}\nPassenger Class.: {PClass}";
        }
         
    }
}