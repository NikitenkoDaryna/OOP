using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB6
{
    //12 variant; (lg(4*b-c)*a)/(b+c/d-1) 
    //val2=d
    class Program
    {
        static void Main(string[] args) { 
        
            Problem p1 = new Problem(4,2,0);
            Problem p2 = new Problem(2, 3, 4);
            var p3 = p1 *3 ;
            Console.WriteLine(p3);
            Collection<Problem> problems = new Collection<Problem>();
            problems.Add(p1);
            problems.Add(p2);

            Console.WriteLine($"Problem 1: {problems[0]*3}");
            Console.WriteLine($"Problem 2: {problems[1]*2}");
            Console.ReadKey();
           
        }
    }

}
