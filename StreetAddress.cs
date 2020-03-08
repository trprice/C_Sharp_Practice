using System;
using System.Collections.Generic;
using System.Text;

namespace Module1_Assignment
{
    class StreetAddress
    {
        String Address_FirstLine;
        String Address_SecondLine;
        String City;
        String State;
        String ZipCode;
        String Country;

        public StreetAddress()
        {
            Address_FirstLine = "";
            Address_SecondLine = "";
            City = "";
            State = "";
            ZipCode = "";
            Country = "";
        }
        
        public void SetAddress(String Address_FirstLine,
                               String Address_SecondLine,
                               String City,
                               String State,
                               String ZipCode,
                               String Country)
        {
            this.Address_FirstLine = Address_FirstLine;
            this.Address_SecondLine = Address_SecondLine;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
            this.Country = Country;
        }
    }
}