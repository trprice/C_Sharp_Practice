using System;

namespace Module1_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student bob = new Student("Bob", "Barker", new DateTime(2002, 01, 01), new StreetAddress("123 Main St", "Apt A", "Plainsville", "AK", "34512", "US"));
            Student rob = new Student("Rob", "Robertson", new DateTime(1999, 12, 31), new StreetAddress("123 Main St", "Apt B", "Plainsville", "AK", "34512", "US"));
            Student james = new Student("James", "Jameson", new DateTime(1995, 07, 01), new StreetAddress("123 Main St", "Apt A", "Plainsville", "AK", "34512", "US"));

            Teacher teach = new Teacher("Prof", "Guy", new DateTime(1960, 09, 25), new StreetAddress("124 Main St", "", "Plainsville", "AK", "34512", "US"));

            CourseInformation course = new CourseInformation("Programming in C#", 4, 10, teach);

            Degree bachelors_info_tech = new Degree("Bachelors in Information Technology", 40);

            UProgram information_technology = new UProgram("Information Technology", teach);

            information_technology.AddDegree(bachelors_info_tech);

            Console.WriteLine("Program: {0}", information_technology.ProgramName);
            Console.WriteLine("Degrees in {0}:", information_technology.ProgramName);
            
            foreach(Degree degree in information_technology.Degrees)
            {
                Console.WriteLine("     {0}", degree.ToString());
            }
        }
    }
}
