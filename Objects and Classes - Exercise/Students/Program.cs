using System.Diagnostics;

namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentDetails = Console.ReadLine()
                    .Split()
                    .ToArray();

                Student student = new Student();
                student.FirstName = studentDetails[0];
                student.LastName = studentDetails[1];
                student.Grade = double.Parse(studentDetails[2]);
                students.Add(student);
            }

            students = students.OrderByDescending(student => student.Grade).ToList();
            Console.WriteLine(string.Join("\n", students));
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}