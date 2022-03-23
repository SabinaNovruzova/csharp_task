using System;
using task1.Models;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {            
            Person student = new Person("Sebine", "Novruzova", 21);
            Person employee = new Person("Veli", "Memmedov", 18);

            Employee e = new Employee();
            e.person = employee;

            Console.WriteLine($"Ishci:{e.person.Name} {e.person.Surname}");
            Console.WriteLine(e.CalculateSalary(200,8,e.person.Age));

            Student st = new Student();
            st.person = student;
            Console.WriteLine($"Student:{st.person.Name} {st.person.Surname}");

            Console.WriteLine(st.ExamResult(50, 60, st.person.Age));


        }
    }
}
