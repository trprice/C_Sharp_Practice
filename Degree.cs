using System;
namespace Module1_Assignment
{
    public class Degree
    {
        string _degree_name;

        public string DegreeName
        {
            get { return _degree_name; }
            set { if (value != null) _degree_name = value; }
        }

        ushort _units_required;

        public ushort UnitsRequired
        {
            get { return _units_required; }
            set { _units_required = value; }
        }

        public Degree(string degreeName, ushort unitsRequired)
        {
            _degree_name = degreeName;
            _units_required = unitsRequired;
        }

        public override string ToString()
        {
            return _degree_name + " (Units Required: " + _units_required + ")";
        }
    }
}
