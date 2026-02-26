using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            var age = 20;

            var val = 30; // call by reference must be initialized before calling the method

            int Salary; // call by out must not initialized ,بس جواه الميثود لاوم اعطيله قيمه ابتدائيه 
            
            demo.Method1(age);

            Console.WriteLine(age); // Output: 20
            // Explanation: In C#, method parameters are passed by value by default. This means that when you pass a variable to a method, a copy of the variable is created and used within the method. Therefore, any changes made to the parameter inside the method do not affect the original variable outside the method. In this case, when we call demo.Method1(age), a copy of the age variable (which has a value of 20) is passed to Method1. Inside Method1, the age parameter is modified by adding 10 to it, but this does not change the original age variable in the Main method. As a result, when we print age after calling Method1, it still outputs 20.
             
            demo.Method2(ref val);
            Console.WriteLine(val); // Output: 50
            // Explanation: In C#, when you use the ref keyword in a method parameter, it allows you to pass a variable by reference. This means that instead of passing a copy of the variable, you are passing a reference to the original variable. Therefore, any changes made to the parameter inside the method will affect the original variable outside the method. In this case, when we call demo.Method2(ref val), we are passing a reference to the val variable (which has a value of 30) to Method2. Inside Method2, the val parameter is modified by adding 20 to it, which changes the original val variable in the Main method. As a result, when we print val after calling Method2, it outputs 50.

            demo.Method3( out Salary);
            Console.WriteLine(Salary); // Output: 6000

            // من اشهر استخدام لل out  (tryparse)

            var numstring = "123456s";

            int number;
            +
            if (!int.TryParse(numstring, out number))
            {
                Console.WriteLine("invalid number ");
            }
            else
            {
                Console.WriteLine($" you provided a vaild number {number}");
            }


        }
    }
    public class Demo
    {
        public void Method1(  int  age )
        {
            age = age + 10;
        }
        public void Method2( ref int val )
        {
            val =val + 20;
        }
        public void Method3( out int Salary)

        {
            Salary = 4000;
            Salary= Salary + 2000;
        }

    }


}
