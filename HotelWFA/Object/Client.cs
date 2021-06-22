using System;
using System.Collections.Generic;
using System.Text;

namespace HotelWFA
{
    class Client
    {
        public int clientCode { get; set; }
        public int roomCode { get; set; }
        public string fullName { get; set; }
        public decimal passportProperties { get; set; }
        public decimal phoneNumber { get; set; }
        public DateTime dateOfPlacement { get; set; }
        public DateTime dateOfEviction { get; set; }

        public Client()
        {
            clientCode = default(int);
            roomCode = default(int);
            fullName = default(string);
            passportProperties = default(decimal);
            phoneNumber = default(decimal);
            dateOfPlacement = default(DateTime);
            dateOfEviction = default(DateTime);
        }

        public Client(int _clientCode, int _roomCode, string _fullName, decimal _passportProperties, decimal _phoneNumber, DateTime _dateOfPlacement, DateTime _dateOfEviction)
        {
            clientCode = _clientCode;
            roomCode = _roomCode;
            fullName = _fullName;
            passportProperties = _passportProperties;
            phoneNumber = _phoneNumber;
            dateOfPlacement = _dateOfPlacement;
            dateOfEviction = _dateOfEviction;
        }
    }
}
