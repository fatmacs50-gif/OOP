using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Money m1 = new Money( 10.5678m );
            Money m2 = new Money(20.5678m);
            Money m3 = m1 + m2; 
            
            // Using the overloaded + operator to add two Money objects

            Console.WriteLine( $"Money m1 :  {  m1.Amount}, Money m2 : {m2.Amount}" );
            Console.WriteLine($"Money m3 :  {m3.Amount}");




          Console.ReadKey();
        }

        class Money
        {
            private decimal amount;

            public decimal  Amount => amount; 


            public Money( decimal  Value)
            {
                this.amount = Math.Round( Value, 2 );
                
            }

            public static Money operator +( Money money1, Money money2 )
            {
               var value   = money1.Amount+ money2.Amount;
                return new Money(value);      
            }




        }
    }
}
