using System;
using System.Collections.Generic;
using System.Text;

namespace HotelWFA
{
    class Order
    {
        public int orderCode { get; set; }
        public int clientCode { get; set; }
        public int employeeCode { get; set; }
        public int serviceCode { get; set; }
        public decimal quentity { get; set; }
        

        public Order()
        {
            orderCode = default(int);
            clientCode = default(int);            
            employeeCode = default(int);
            serviceCode = default(int);
            quentity = default(decimal);
        }
        public Order(int _orderCode, int _clientCode, int _employeeCode, int _serviceCode, decimal _quentity)
        {
            orderCode = _orderCode;
            clientCode = _clientCode;
            employeeCode = _employeeCode;
            serviceCode = _serviceCode;
            quentity = _quentity;
        }
    
    }
}
