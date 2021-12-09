using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace CSModels
{
    public class PassengerActivities
    {
        private int _cabinNo;
        private string _pName;
        private int _actIdNo;
        private String _actName;
        public int CNo
        {
            get { return _cabinNo; }
            set
            {
                _cabinNo = value;
            }
        }
        public string PName
        {
            get { return _pName; }
            set
            {
                _pName = value;
            }
        }
        public int AIdNo
        {
            get { return _actIdNo; }
            set
            {
                _actIdNo = value;
            }
        }
        public string AName
        {
            get { return _actName; }
            set
            {
                _actName = value;
            }
        }
        public override string ToString()
        {
            return $"Passanger: {PName}\n Activity Id: {AIdNo}";

        }
    }
}