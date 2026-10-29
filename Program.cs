using System;
using System.Collections.Generic;
using System.Linq;
using LINQ;
public class Employee
{

    //  public int MyProperty { get; set; }
    public int ID { get; set; } // properties are combo of set and get menthods
    public string? Name { get; set; }
    public int Salary { get; set; }
}
class Program
{

    public static int CalculateAge(DateTime dateOfBirth)
    {
        // Get today's date
        DateTime today = DateTime.Today;

        // Calculate the preliminary age
        int age = today.Year - dateOfBirth.Year;

        // Go back one year if the birthday hasn't happened yet this year
        if (dateOfBirth.Date > today.AddYears(-age))
        {
            age--;
        }

        return age;
    }
    public static void Main()
    {

        //DateTime dob = new DateTime(2005, 07, 13); // July 13, 2005
        //int exactAge = CalculateAge(dob);

        //Console.WriteLine($"Age: {exactAge}");


        //List<Employee> listEmployees = new List<Employee>
        //    {
        //        new Employee { ID= 1001, Name = "Dharshini", Salary = 34000 },
        //        new Employee { ID= 1002, Name = "Varsha", Salary = 91000 },
        //        new Employee { ID= 1003, Name = "Srinithi", Salary = 93000 },
        //        new Employee { ID= 1004, Name = "Vikram", Salary = 88000 },
        //        new Employee { ID= 1005, Name = "Dinesh", Salary = 91000 },
        //        new Employee { ID= 1006, Name = "Ameeruuuu", Salary = 20001 },
        //        new Employee { ID= 1007, Name = "Santhosh", Salary = 27000 }
        //    };
        //// In the below statement the LINQ Query is only defined and not executed
        //// If the query is executed here, then the result should not display Anubhav

        //IEnumerable<Employee> result = (from emp in listEmployees
        //                                where emp.Salary < 50000
        //                                select emp).Distinct().ToList(); // Immediate
        //Console.WriteLine("There are " + result.Count() + " employees whose salary is less than 50000");
        //Console.WriteLine("The employees are:");
        //foreach (Employee emp in result)
        //{
        //    Console.WriteLine($" {emp.ID} {emp.Name} {emp.Salary}");
        //}
        //Console.ReadKey();

        //double AvgSalary = listEmployees.Average(emp => emp.Salary);
        //Console.WriteLine($"Average Salary of Employees is: {AvgSalary}");

        //int MaxSalary = listEmployees.Max(emp => emp.Salary);
        //Console.WriteLine($"Maximum Salary of Employees is: {MaxSalary}");

        //int MinSalary = listEmployees.Min(emp => emp.Salary);
        //Console.WriteLine($"Minimum Salary of Employees is: {MinSalary}");

        //IEnumerable<Employee> resultOrder = listEmployees.OrderBy(emp => emp.Salary).ToList();


        //IEnumerable<Employee> result2 = from emp in listEmployees
        //                                where emp.Salary > 90000
        //                                select emp; // Deferred execut

        //double ECount = result.Count(); // Immediate execution
        //Console.WriteLine(ECount);
        //Console.WriteLine("After adding Pradeeban");
        //// Adding a new employee with Salary = 80000 to the collection listEmployees
        //listEmployees.Add(new Employee { ID = 1008, Name = "Pradeeban", Salary = 98000 });
        //double Avg = result.Average(emp => emp.Salary);
        //double Max = result.Min(emp => emp.Salary);
        //Console.WriteLine($"Maximun: {Max}");
        //Console.WriteLine($"Average: {Avg}");
        //double ECount1 = result.Count();
        //Console.WriteLine(ECount1);
        //// The LINQ query is actually executed when we iterate thru using a for each loop
        //// This is proved because Santosh is also included in the result
        //Console.WriteLine("Immediate");
        //foreach (Employee emp in result)
        //{
        //    Console.WriteLine($" {emp.ID} {emp.Name} {emp.Salary}");
        //}

        //Console.WriteLine("Immediate - Order by");
        //foreach (Employee emp in resultOrder)
        //{
        //    Console.WriteLine($" {emp.ID} {emp.Name} {emp.Salary}");
        //}


        //Console.WriteLine("Deferred");

        //foreach (Employee emp in result2)
        //{
        //    Console.WriteLine($" {emp.ID} {emp.Name} {emp.Salary}");
        //}
        //Console.ReadKey();


        ////Fetching the First Element from the Data Source using First Method
        //List<string?> Students = new List<string?>() { };
        ////Using Method Syntax
        //string MethodSyntax = Students.FirstOrDefault();
        ////Query Syntax
        //string QuerySyntax = (from nam in Students
        //                      select nam).FirstOrDefault();
        ////Printing the value returned by the First Method
        //Console.WriteLine(MethodSyntax);
        //Console.ReadLine();
        copilot cp = new copilot();
        Console.WriteLine(cp.FindSecondLargest());
    }
}
