namespace StudentExpresions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProgramMain
    {
        public static void Main()
        {
            var studentList = new List<Student> {
                new Student { FirstName = "Ivan",LastName="Petrov", Age = 25},
                new Student { FirstName = "Gosho",LastName="Ivanov",Age = 23},
                new Student { FirstName = "Alex",LastName="Dimitrov",Age = 13},
                new Student { FirstName = "Plamen",LastName="Stamenov",Age = 19},
                new Student { FirstName = "Ivo",LastName="Kunchev",Age = 21},
            };

            var sortedStudent = FirstName(studentList);
            Console.WriteLine("This is list sorted by all students whose first name is before its last name alphabetically:");
            foreach (var student in sortedStudent)
            {
                Console.WriteLine(student);    
            }
            Console.WriteLine();

            int startAge = 18;
            int endAge = 24;
            var studentInActiveAge = PeopleInActiveAge(studentList, startAge, endAge);
            Console.WriteLine("This is list of student sorted by actuve age:");
            foreach (var student in studentInActiveAge)
            {
                Console.WriteLine(student);
            }
        }
        private static IEnumerable<Student> FirstName(List<Student> studentList)
        {
            IEnumerable<Student> result =
                from student in studentList
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;
            return result;
        }
        private static IEnumerable<Student> PeopleInActiveAge(List<Student> studentsList, int startAge, int endAge)
        {
            IEnumerable<Student> result =
                from student in studentsList
                where student.Age >= startAge && student.Age <= endAge
                select student;

            return result;
        }

    }

}
