using System;
using System.Collections.Generic;
using System.Text;

namespace HotelWFA
{
    class Service
    {
        public int serviceCode { get; set; }
        public string serviceName { get; set; }
        public string category { get; set; }
        public decimal price { get; set; }

        public Service()
        {
            serviceCode = default(int);
            serviceName = default(string);
            category = default(string);
            price = default(decimal);
        }
        public Service(int _serviceCode, string _serviceName, string _category, decimal _price)
        {
            serviceCode = _serviceCode;
            serviceName = _serviceName;
            category = _category;
            price = _price;
        }
    }
}
