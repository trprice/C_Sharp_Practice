using System;
using System.Collections.Generic;

namespace Module1_Assignment
{
    public class UProgram
    {
        string _program_name;

        public string ProgramName
        {
            get { return _program_name; }
            set { if (value != null) _program_name = value; }
        }

        Person _department_head;

        public Person DepartmentHead
        {
            get { return _department_head; }
            set
            {
                // Does the assignment operator call a copy constructor?
                if (value != null)
                    _department_head = value;
            }
        }

        List<Degree> _degrees;

        public List<Degree> Degrees
        {
            get { return _degrees; }

            // It makes sense to make this property read only and use AddDegree and RemoveDegree to handle array management
        }

        public void AddDegree (Degree degree)
        {
            _degrees.Add(degree);
        }

        // TODO: Add RemoveDegree()

        public UProgram(string programName, Person departmentHead)
        {
            _program_name = programName;
            _department_head = departmentHead;
            _degrees.Clear();
        }
    }
}
