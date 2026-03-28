using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace NestedType
{ 
     public  class Program
    {
        static void Main(string[] args)
        {
            Employees e = new Employees();
            Console.WriteLine(e.EmployeeInsurance.CompanyName);
        }

        // Composite  object initialization 

        class Employees 
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Insurance EmployeeInsurance { get; set; } //  Insurance دا عباره عن اوبيجكت من كلاس 

            public Employees() =>
             //  هعطي قيم ابتدائيه علشان الطباعه 
                EmployeeInsurance = new Insurance { policyId = 3, CompanyName = " .Net " };



            

            public class Insurance

            {
                public int policyId { get; set; }

                public string CompanyName { get; set; }

            }

        }

        

       
      }

        
    
}
