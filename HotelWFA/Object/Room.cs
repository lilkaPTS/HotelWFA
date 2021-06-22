using System;
using System.Collections.Generic;
using System.Text;

namespace HotelWFA
{
    class Room
    {
        public int roomCode { get; set; }
        public int roomNumber { get; set; }
        public int storey { get; set; }
        public int capacity { get; set; }
        public string classification { get;set;}
        public decimal price { get; set; }

        public Room()
        {
            roomCode = default(int);
            roomNumber = default(int);
            storey = default(int);
            capacity = default(int);
            classification = default(string);
            price = default(decimal);
        }

        public Room(int _roomCode, int _roomNumber, int _storey, int _capacity, string _classification, decimal _price)
        {
            roomCode = _roomCode;
            roomNumber = _roomNumber;
            storey = _storey;
            capacity = _capacity;
            classification = _classification;
            price = _price;
        }
    }
}
