namespace Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employeesCount = int.Parse(Console.ReadLine());
            List<Department> departmentList = new List<Department>();
            for (int i = 0; i < employeesCount; i++)
            {
                string[] details = Console.ReadLine()
                    .Split()
                    .ToArray();
                Employee employee = new Employee();
                employee.Name = details[0];
                employee.Salary = double.Parse(details[1]);
                if (departmentList.Any(x => x.Name == details[2]))
                {
                    int index = departmentList.FindIndex(x => x.Name == details[2]);
                    departmentList[index].Employees.Add(employee);
                    continue;
                }

                Department department = new Department();
                department.Name = details[2];
                department.Employees.Add(employee);
                departmentList.Add(department);
            }

            for (int i = 0; i < departmentList.Count; i++)
            {
                departmentList[i].AverageSalary = departmentList[i].GetAverageSalary(departmentList[i].Employees);
            }

            int biggestSalaryIndex = departmentList.FindIndex(x => x.AverageSalary == departmentList.Max(x => x.AverageSalary));
            departmentList[biggestSalaryIndex].Employees = departmentList[biggestSalaryIndex].Employees.OrderByDescending(x => x.Salary).ToList();

            Console.WriteLine($"Highest Average Salary: {departmentList[biggestSalaryIndex].Name}");
            foreach (Employee employee in departmentList[biggestSalaryIndex].Employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
           
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
    }

    public class Department
    {
        public Department()
        {
            Employees = new List<Employee>();
        }

        public double GetAverageSalary(List<Employee> employees)
        {
            return Employees.Average(x => x.Salary);
        }
        public string Name { get; set; }
        public double AverageSalary { get; set; }
        public List<Employee> Employees { get; set; }
    }

}