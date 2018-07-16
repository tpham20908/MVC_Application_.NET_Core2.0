using System;
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
            // store different type in array in C#? Yes with object array or ArrayList
            object[] arr = new object[3];
            arr[0] = 34.76;
            arr[1] = "Montreal";
            arr[2] = new Customer { Id = 109, Name = "Phillip" };

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
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
