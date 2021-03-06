﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Module1_Assignment
{
    public class Person
    {
        string _first_name;
        public string FirstName
        {
            get { return _first_name; }
            set { if (value != null) _first_name = value; }
        }

        string _last_name;
        public string LastName
        {
            get { return _last_name; }
            set { if (value != null) _last_name = value; }
        }

        DateTime _birthday;
        public DateTime Birthday
        {
            get { return _birthday; }
            set
            {
                if (value != null)
                {
                    // Not checking whether it succeeded because what would we
                    // do if it wasn't? Throw an exception?
                    DateTime.TryParse(value.ToString(), out _birthday);
                }
            }
        }

        StreetAddress _address;

        public StreetAddress Address
        {
            get { return _address; }
            set { if (value != null) _address = value; }
        }

        public Person(string firstName, string lastName, DateTime birthday, StreetAddress address)
        {
            _first_name = firstName;
            _last_name = lastName;
            _birthday = birthday;
            _address = address;
        }
    }
}
