namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            List<Student> students = new List<Student>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] studentDetails = input.Split().ToArray();

                Student student = new Student();
                student.FirstName = studentDetails[0];
                student.LastName = studentDetails[1];
                student.Age = int.Parse(studentDetails[2]);
                student.HomeTown = studentDetails[3];

                students.Add(student);
            }

            string cityName = Console.ReadLine();

            foreach (Student student in students)
            {
                if (cityName == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}