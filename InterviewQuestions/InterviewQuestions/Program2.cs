using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class Program2
    {
        public static void main(String[] args)
        {
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

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                string[] innerArr = jaggedArr[i];
                for (int j = 0; j < innerArr.Length; j++ )
                {
                    Console.WriteLine(innerArr[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
