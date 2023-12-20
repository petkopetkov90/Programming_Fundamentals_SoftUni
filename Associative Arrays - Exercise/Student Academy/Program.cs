namespace Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            for (int i = 0; i < rows; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    Student student = new Student(studentName);
                    students.Add(studentName, student);
                }

                students[studentName].Grades.Add(studentGrade);
            }

            foreach (KeyValuePair<string, Student> studentPair in students.Where(student => student.Value.Grades.Average() >= 4.50))
            {
                Console.WriteLine($"{studentPair.Value.Name} -> {studentPair.Value.Grades.Average():f2}");
            }
        }
    }

    public class Student
    {
        public Student(string name)
        {
            Name = name;
            Grades = new List<double>();
        }
        public string Name { get; set; }
        public List<double> Grades { get; set; }
    }
}