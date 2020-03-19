using System;
using System.Collections.Generic;
using System.Text;

namespace Module1_Assignment
{
    public class Teacher : Person
    {
        public Teacher(string firstName, string lastName, DateTime birthday, StreetAddress address) :
            base(firstName, lastName, birthday, address)
        {
        }
    }
}
