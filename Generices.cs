using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Generices.Program;

namespace Generices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product< decimal , string > P = new Product <decimal, string>();

            P.Name= "Laptop";
            P.Price= 50000;
            P.product();

            Product<int, string> P2 = new Product<int, string>();

            P2.Name = "Laptop";
            P2.Price = 50000;
            P2.product();

            P.PrintProduct(1034 ,"test");

            Printer e = new Printer();

            e.Print<int>(100); // Calling the generic method with int type
            e.Print("fatma");// ممكن مكتيش لداتا تايب وهوا هيعرف من البرامتر 


            ICointainer<double> cointainer = new Box<double>();
            cointainer.Add( 87.234);



            ICointainer<int> cointainer2 = new Box<int >();
            cointainer2.Add(2);

            CompanyEnterance<Employee> camp = new CompanyEnterance<Employee>();

            camp.AllowEntry( new Employee());


        }

          public class Product<T , U> // Generic class 
        {
            public T Price { get; set; }
            public U  Name { get; set; }

            public T[] ProductSpecific = new T[10]; // Array of type T to hold product-specific values


            public void  product()
            {
                Console.WriteLine($"Name: {Name} - Price: {Price}");
            }


            public T PrintProduct(T name, string description ) // Generic method (Paramater or return type)
            {
              return name;
            }
        }

          public class Printer
        {
            public void Print<T>(  T value) // Generic method
            {
                Console.WriteLine(value);
            }
        }

        // classes , fieldes , methods , properties  , Array ,  interface  can be generic

           public interface ICointainer <T> where T: struct // consintrain 
           {
            void Add( T item);
         
           }

           public class Box<T> : ICointainer<T>  where  T  : struct // Generic class 
           {
            public   void Add (T item)
           {
                Console.WriteLine($"Item '{item}' added to the box.");

           }
        }

          public  interface  IEmployee
          {

              void DoWork(); 



          }
         public class Employee : IEmployee
        {
            public void DoWork()
            {
                Console.WriteLine("Employee is doing work.");
            }
        }


        //  هعمل كلاس جينرك ولازم ياخد مني اي كلاس من نوع الانترفيس (iemployee)  عشان اقدر استخدمه



        public  class  CompanyEnterance <T> where T: class , IEmployee // consintrain  بتقول ان T لازم يكون كلاس ويمتثل للانترفيس IEmployee
        {
            public  void AllowEntry(T employee) 
            {
                Console.WriteLine("Allowing entry to the company.");
              
            }
        }

    }
}
