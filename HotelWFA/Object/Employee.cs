using System;
using System.Collections.Generic;
using System.Text;

namespace HotelWFA
{
    class Employee
    {
        public int employeeCode { get; set; }
        public string fullName { get; set; }
        public DateTime dOB { get; set; }
        public DateTime hiringDate { get; set; }
        public decimal passportProperties { get; set; }
        public string homeAddress { get; set; }
        public decimal phoneNumber { get; set; }
        public string position { get; set; }
        public Employee()
        {
            employeeCode = default(int);
            fullName = default(string);
            dOB = default(DateTime);
            hiringDate = default(DateTime);
            passportProperties = default(decimal);
            homeAddress = default(string);
            phoneNumber = default(decimal);
            position = default(string);
        }

        public Employee(int _employeeCode, string _fullName, DateTime _dOB, DateTime _hiringDate, decimal _passportProperties, string _homeAddress, decimal _phoneNumber, string _position)
        {
            employeeCode = _employeeCode;
            fullName = _fullName;
            dOB = _dOB;
            hiringDate = _hiringDate;
            passportProperties = _passportProperties;
            homeAddress = _homeAddress;
            phoneNumber = _phoneNumber;
            position = _position;
        }
    }
}
