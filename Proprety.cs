using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    internal class Program

    {

        static void Main(string[] args)

        {   Dollar dollar = new Dollar (1);// need to pass a value to the constructor because it has a parameter

            dollar.Amount =9.678m; // we can set the value of the property because it has a setter

            Console.WriteLine(dollar.Amount );

        }


        public class Dollar
        {

            private  decimal _amount; 

            public decimal Amount  // داخل الكلاس اقدر اتعامل مع البرايفت فيلد باستخدام بروبرتي لكن بره  الكلاس بطريقه مباشره لا 
            {
                get
                {

                    return this._amount;

                }
                set
                {
                    this._amount = processvalue(value ); 
     
                }
            }

            public Dollar(decimal _amount)
            {
                this._amount = processvalue(_amount);

            }


                private decimal processvalue(decimal amount) => amount <= 0 ? 0 : Math.Round(amount, 2);

            // this is a local function that takes a decimal value and returns 0 if the value is less than or equal to 0, otherwise it returns the value itself

          
        }


        }


        }
    

