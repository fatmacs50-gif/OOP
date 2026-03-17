using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegates
{
    delegate void RectDelegate(decimal Height, decimal Width);
    internal class Program
    {
        static void Main(string[] args)
        {
       
            RectangelHelper  helper  = new RectangelHelper();

            RectDelegate obj = helper.Area;

            obj+= helper.Perimeter; // Multicast Delegate ,  باستخدام +=  يمكننا اضافة اكثر من داله الى نفس الديليغيت

            obj(10, 10);

            Console.WriteLine("after unsubscribe  obj.Area ");

           obj-= helper.Area; // Unsubscribe  ,  باستخدام -=  يمكننا ازاله داله من الديليغيت
           
            obj(10, 10);




        }



        public class RectangelHelper
        { 
             public void Area (decimal Height , decimal Width)
            {

                var Result = Height * Width;

                Console.WriteLine($"Area of Rectangle is :  {Height} x {Width} = {Result }");



            }

            public void Perimeter (decimal Height, decimal Width)
            {

                var Result = 2*( Height * Width);

                Console.WriteLine($"Perimeter of Rectangle is : 2 *({  Height} x {Width}) = {Result}");



            }



        }





    }
}
