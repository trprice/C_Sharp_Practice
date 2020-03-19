using System;
using System.Collections.Generic;
using System.Text;

namespace Module1_Assignment
{
    class Student : Person
    {
        public Student(string firstName, string lastName, DateTime birthday, StreetAddress address) :
            base(firstName, lastName, birthday, address)
        {
        }
    }
}
