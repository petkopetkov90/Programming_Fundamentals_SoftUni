namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Course> courses = new Dictionary<string, Course>();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commands = command.Split(" : ");
                string courseName = commands[0];
                string studentName = commands[1];

                if (!courses.ContainsKey(courseName))
                {
                    Course course = new Course(courseName);
                    courses.Add(courseName, course);
                }

                courses[courseName].Students.Add(studentName);  
            }

            Console.WriteLine(string.Join("\n", courses.Values));
        }
    }

    public class Course
    {
        public Course(string name)
        {
            Name = name;
            Students = new List<string>();
        }

        public string Name { get; set; }
        public List<string> Students { get; set; }

        public override string ToString()
        {
            string output = $"{Name}: {Students.Count}";
            output += PrintStudents();

            return output;
        }

        private string PrintStudents()
        {
            string output = "";
            for (int i = 0; i < Students.Count; i++)
            {
                output += $"\n-- {Students[i]}";
            }
            return output;
        }
    }
}