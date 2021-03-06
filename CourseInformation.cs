﻿using System;
using System.Collections.Generic;

namespace Module1_Assignment
{
    public class CourseInformation
    {
        string _course_name;

        public string CourseName
        {
            get { return _course_name; }
            set { if (value != null) _course_name = value; }
        }

        ushort _credits;

        public ushort Credits
        {
            get { return _credits; }
            set { _credits = value; }
        }

        ushort _duration_in_weeks;

        public ushort DurationInWeeks
        {
            get { return _duration_in_weeks; }
            set { _duration_in_weeks = value; }
        }

        Teacher _course_teacher;

        public Teacher CourseTeacher
        {
            get { return _course_teacher; }
            set { if (value != null) _course_teacher = value; }
        }

        List<Student> _students;

        public List<Student> Students
        {
            get { return _students; }
        }

        public void AddStudent(Student student)
        {
            if (student != null)
                _students.Add(student);
        }

        public CourseInformation(string courseName, ushort credits, ushort duration, Teacher teacher)
        {
            _course_name = courseName;
            _credits = credits;
            _duration_in_weeks = duration;
            _course_teacher = teacher;
            _students = new List<Student>();
        }

        public override string ToString()
        {
            return _course_name;
        }
    }
}
