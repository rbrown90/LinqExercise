using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            var sum = numbers.Sum();          //TODO: Print the Sum of numbers
            Console.WriteLine(sum);

            Console.WriteLine("-----------------");

            var avg = numbers.Average();      //TODO: Print the Average of numbers
            Console.WriteLine(avg);

            Console.WriteLine("------------------");

            var asc = numbers.OrderBy(num => num);     //TODO: Order numbers in ascending order and print to the console
            foreach (var num in asc)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("-------------------");

            var dec = numbers.OrderByDescending(num => num); //TODO: Order numbers in decsending order and print to the console
            foreach (var num in dec)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("--------------------");

            var greaterThanSix = numbers.OrderBy(num => num > 6); //TODO: Print to the console only the numbers greater than 6
            foreach (var num in greaterThanSix)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("---------------------");

            var whichever = numbers.OrderBy(num => num); //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            foreach (var item in whichever)
            {
                if (item > 5)
                {
                    Console.WriteLine($"{item}");
                }
                else
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine("-----------------------");

            numbers[4] = 32;//TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            var decs = numbers.OrderByDescending(num => num);
            foreach (var num in decs)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("------------------------");

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            var letterFilter = employees.Where(name => name.FirstName.StartsWith('C') || name.FirstName.StartsWith('S')).OrderBy(name => name.FirstName);//TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            foreach(var name in letterFilter)
            {
                Console.WriteLine(name.FullName);
            }

            Console.WriteLine("----------------------");


            var ageFilter = employees.Where(name => name.Age > 26).OrderBy(name => name.Age).ThenBy(name => name.FirstName);//TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            foreach (var name in ageFilter)
            {
                Console.WriteLine($"{name.FullName}: {name.Age}");
            }

            Console.WriteLine("----------------------");

            var years = employees.Where(name => name.YearsOfExperience >= 10 && name.Age < 35);//TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine($"Sum : {years.Sum(name => name.YearsOfExperience)}");
            Console.WriteLine($"Avg: {years.Average(name => name.YearsOfExperience)}");

            Console.WriteLine("-----------------------");

            employees = employees.Append(new Employee("Leon", "Kennedy", 23, 2)).ToList();//TODO: Add an employee to the end of the list without using employees.Add()
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}, {item.Age}, {item.YearsOfExperience}");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
