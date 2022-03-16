using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220316_ZodiaC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入你的分數：");
            int score = Convert.ToInt32(Console.ReadLine());
            string Result = score >= 60 ? "及格" : "不及格";
            Console.WriteLine("同學，你這次"+Result);
            Console.ReadLine();
        }
    }
}
