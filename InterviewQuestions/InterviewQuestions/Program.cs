using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            // delegate is a type safe function pointer
            DelegateEx del = new DelegateEx(Hello);
            del("Greeting from Hello function");

            /*
            // abstract class
            FulltimeEmployee fte = new FulltimeEmployee()
            {
                ID = 209,
                FirstName = "John",
                LastName = "Doe",
                AnnualSalary = 87000
            };

            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());
            Console.WriteLine("-----------------------");

            ContractEmployee cte = new ContractEmployee()
            {
                ID = 213,
                FirstName = "Jane",
                LastName = "Doe",
                HourlyPay = 35,
                TotalHours = 170
            };

            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());
            */

            /*
            // 2. jagged array is an array of arrays
            string[][] jaggedArr = new string[3][];
            jaggedArr[0] = new string[3];
            jaggedArr[1] = new string[1];
            jaggedArr[2] = new string[2];

            jaggedArr[0][0] = "Bachelor";
            jaggedArr[0][1] = "Master";
            jaggedArr[0][2] = "PhD";

            jaggedArr[1][0] = "Bachelor";

            jaggedArr[2][0] = "Bachelor";
            jaggedArr[2][1] = "Master";

            foreach (var item in jaggedArr)
            {
                foreach (var innerItem in item)
                {
                    Console.WriteLine(innerItem);
                }
                Console.WriteLine();
            }
            */

            /*
            // 1. store different type in array in C#? Yes with object array or ArrayList

            //object[] arr = new object[3];
            //arr[0] = 34.76;
            //arr[1] = "Montreal";
            //arr[2] = new Customer { Id = 109, Name = "Phillip" };

            ArrayList arr = new ArrayList();
            arr.Add(234.88);
            arr.Add("Toronto");
            arr.Add(new Customer { Id = 1009, Name = "Valerie" });

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            */
        }

        public static void Hello(string str)
        {
            Console.WriteLine(str);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
