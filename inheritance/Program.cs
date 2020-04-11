using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jono", 16);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Joni", 33, "191100", "Computer Networking");
            teacher.GetNameAndAge();

            Student student = new Student("Umi Solihah", 18, "19.11.2747", "umi.solihah@students.amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name = "no name", int age = 0)
        {
            Name = name;
            Age = age;
        }

        public void GetNameAndAge()
        {
            Console.WriteLine("The person has name: {0} and age: {1}", Name, Age);
        }
    }

    public class Teacher : Person
    {

        public string TeacherId { get; set; }
        public string Subject { get; set; }

        public Teacher(string name = "no name", int age = 0, string teacherId = "no id", string subject = "no subject")
        {
            Name = name;
            Age = age;
            TeacherId = teacherId;
            Subject = subject;
        }
    }

    public class Student : Person
    {
        public string StudentId { get; set; }
        public string Email { get; set; }

        public Student(string name = "no name", int age = 0, string studentId = "no id", string email = "no email")
        {
            Name = name;
            Age = age;
            StudentId = studentId;
            Email = email;
        }
    }

}