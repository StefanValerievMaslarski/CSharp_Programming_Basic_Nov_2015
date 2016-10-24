using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        //static void PrintNames(List<string> names)
        //{
        //    foreach (var name in names)
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
        static void Main()
        {
            //List<int> numbers = new List<int>();
            //numbers.Add(5);
            //numbers.Add(1);
            //numbers.Add(5);
            //numbers.Add(1);
            //numbers.Add(5);
            //numbers.Add(1);



            //Console.WriteLine(numbers.Capacity);
            // Console.WriteLine(numbers.Count);
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //List<string> names = new List<string>() { "Katya", "Bojko", "Sylvia" };
            //names.Add("Nakov");
            ////names.RemoveAt(0);
            //names.Insert(2, "Penka");
            //names[0] = "Michaek";
            ////for (int i = 0; i < names.Count; i++)
            ////{
            ////    Console.WriteLine(names[i]);
            ////}
            ////foreach (var name in names)
            ////{
            ////    Console.WriteLine(name);
            ////}
            //PrintNames(names);
            //Console.WriteLine("-");
            //PrintNames(names);
            //Dictionary<string, int> students = new Dictionary<string, int>();
            //students.Add("Ivan",2);
            //students.Add("Ivan2", 3);
            //students.Add("Georgi", 4);
            //students.Add("Sasho", 5);
            //students["Ivan"] = 7;
            //foreach (var student in students)
            //{
            //    Console.WriteLine("student name {0} with grade {1}" ,student.Key, student.Value); 
            //}

            //string something = "Something";
            //string[] splitted = something.Split('e');

            //Console.WriteLine(splitted[2]); 
            //string softuni = "softuni";
            //Console.WriteLine(softuni.Substring(3,0)); 
            StringBuilder something = new StringBuilder();

            string softuni = "SoftUni SoftUni SoftUni";
            Console.WriteLine(softuni.ToUpper());
            string soft = softuni.Replace("Soft", "Hard");
            Console.WriteLine(soft);

        }
    }
}
