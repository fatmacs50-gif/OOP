using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {

               var stock = new Stock("Amazon :");

              stock.Price = 400;
              stock.OnPriceChanged += Stock_OnPriceChanged;


               stock.changepriceby(0.05m);
               stock.changepriceby(-0.02m);
               stock.OnPriceChanged-= Stock_OnPriceChanged;  // دا بيشترك في الايفنت وبعدين بيعمل انسابسكرايب يعني مش هيبقي مهتم بالتغيرات اللي بتحصل بعد كدا
            stock.changepriceby(0.00m);
               stock.changepriceby(0.03m);
               stock.changepriceby(-0.01m);
         
        }

        private static void Stock_OnPriceChanged(Stock stock, decimal oldprice)
        {
            string result = " ";
            if (stock.Price > oldprice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                result = " up";
            }
            else if (oldprice > stock.Price)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                result = "down ";
            }
            else
             {
                Console.ForegroundColor=ConsoleColor.Gray;
                Console.WriteLine($" {stock.Name} {stock.Price}");

            }
            Console.WriteLine($" {stock.Name}: $ {stock.Price} - {result}");

        }

        public delegate void PriceChangedEventHandler(Stock stock, decimal oldprice );  // اي حد يشترك ف الايفنت لازم يكون عارف السعر الجديد والقيمه القديمه عشان يقدر يحدد اذا كان السعر ارتفع او نزل
                                                                                         //   اي حد يشترك ف الايفنت دا السيجنتشر اللي لازم يلتزم بيه 
        public class Stock
        {
            private string name;
            private  decimal  price ; 


            public event PriceChangedEventHandler OnPriceChanged; // دا تعريف الايفنت
                                                                 // الداتا تايب بتاع الايفنت دا هو الديليجيت اللي فوق دا
            public string Name => this.name;
            public decimal Price { get => this.price; set => this.price = value; }

            public Stock( string stockname )

            {
                this .name = stockname;
                

            }



            // دا الميثود اللي بيغير السعر(  اللي حصل فيها تغير )وبيعمل ريزنق علي السعر الجديد والقديم عشان يحدد اذا كان السعر ارتفع او نزل وبعدين بيعمل انفاير للايفنت
            public void changepriceby (decimal precentage)
            {
                 decimal oldprice = this.price;

                this.price +=  Math.Round (this.price * precentage, 2) ;

                //ممكن ميكونش ف حد مهتم او مش مشترك في الايفنت ف لازم اعمل تشيك قبل ما اعمل انفاير

                if (OnPriceChanged != null) // make sure there is subscriber 
                {

                    OnPriceChanged(this, oldprice);// firing the event 

                }

            }


        }



    }
}
