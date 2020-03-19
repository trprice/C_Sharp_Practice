using System;
using System.Collections.Generic;
using System.Text;

namespace Module1_Assignment
{
    public class StreetAddress
    {
        string _address_first_line;

        public string Address_FirstLine
        {
            get { return _address_first_line; }
            set { if (value != null) _address_first_line = value; }
        }

        string _address_second_line;

        public string Address_SecondLine
        {
            get { return _address_second_line; }
            set { if (value != null) _address_second_line = value; }
        }

        string _city;

        public string City
        {
            get { return _city; }
            set { if (value != null) _city = value; }
        }

        string _state;

        public string State
        {
            get { return _state; }
            set { if (value != null) _state = value; }
        }

        string _zip_code;
        public string ZipCode
        {
            get { return _zip_code; }
            set { if (value != null) _zip_code = value; }
        }

        string _country;
        public string Country
        {
            get { return _country; }
            set { if (value != null) _country = value; }
        }

        public void SetAddress(String Address_FirstLine,
                               String Address_SecondLine,
                               String City,
                               String State,
                               String ZipCode,
                               String Country)
        {
            _address_first_line = Address_FirstLine;
            _address_second_line = Address_SecondLine;
            _city = City;
            _state = State;
            _zip_code = ZipCode;
            _country = Country;
        }
    }
}