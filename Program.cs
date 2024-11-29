using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1,"Erik","male", 17500);
            Employee employee2 = new Employee(2, "Erika", "female", 16.500);
            Employee employee3 = new Employee(3, "Johannes", "male", 22000);
            Employee employee4 = new Employee(4, "Pär", "male", 35000);
            Employee employee5 = new Employee(5, "Anna", "female", 34600);

            Stack<Employee> list = new Stack<Employee>();

            list.Push(employee1);
            list.Push(employee2);
            list.Push(employee3);
            list.Push(employee4);
            list.Push(employee5);




            // fråga vill dom att man bara ska skriva utt objekten eller deras atributer?

            Console.WriteLine("\nall emplyees in the stack and how many left writen,  using a foreachloop\n");
            
            int number = list.Count();

            foreach (Employee item in list)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine($"{list.Count()} emplyees are left in the stack");
            }

            Console.WriteLine("\nall employees in the stack and how many left using .Pop() method\n");

            int number2 = list.Count;

            for (int i = 1; i <= number2; i++)
            {
                Console.WriteLine(list.Count + " Items remaining in the list");
                Console.WriteLine(list.Pop());
            }

            list.Push(employee1);
            list.Push(employee2);
            list.Push(employee3);
            list.Push(employee4);
            list.Push(employee5);

            Console.WriteLine("\n"+list.Peek() + $"\n {list.Count} items left\n" + list.Peek() + $"\n {list.Count} items left\n");

            //----------------------------------------------------------------------------------------------------------


            List<Employee> lista = new List<Employee>();

            lista.Add(employee1);
            lista.Add(employee2);
            lista.Add(employee3);
            lista.Add(employee4);
            lista.Add(employee5);

            Console.WriteLine("\ncheks if emplyee 3 is in the listn\n ");

            Contains(lista, employee3);

            Console.WriteLine("\n finds the firstEmployee/object that is male and also finds all Males in the list (3 of them)\n");

            Console.WriteLine(lista.Find(x => x.Gender =="male"));

            List<Employee> newList = new List<Employee>();

            newList = lista.FindAll(x => x.Gender == "male");

            foreach (Employee item in newList)
            {
                Console.WriteLine(item.Name + " Is male");

            } 

        }
        public static void Contains(List<Employee> lista,Employee employee)
        {
            if (lista.Contains(employee))
            {
                Console.WriteLine($"{employee} Exists in the list ");
            }
            else
            {
                Console.WriteLine($"{employee} does not exist in the list");
            }
        }
    }
}
