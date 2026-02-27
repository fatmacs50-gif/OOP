using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constractor
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Date date = new Date(1, 3 , 2000 );
            Date date = new Date( 2006);

            Console.WriteLine(date.GetDate());
        }
    }
    // <summary> dd/mm/yyyy      dd[01-31] /Month (int) [01-12] / Year (int) [0001-9999]   </summary>

    public class Date
    {


         private static  readonly int[] DaysToMonth365 = {0 , 31 ,28 , 31 , 30 , 31 , 30 , 31 , 31 , 30 , 31 , 30 , 31 };
         private  static  readonly int[] DaysToMonth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // Readonly field : can be assigned only in declaration or in constructor
        // readonly field : can not be changed after assignment only in declaration or in constructor
        private readonly int day;
        private readonly int month;
        private readonly int year;


        public Date( int day , int month , int year ) 
        {  
             var isLeapYear =year%4==0 && ( year %100 !=0|| year%400==0);
             if ( year >=1 && year <=9999 && month >=1 && month<=12 )
            {
               int[] days =isLeapYear ? DaysToMonth366: DaysToMonth365; //  بخزن فيه عدد ايام الشهر اللي انا فيه
                if (day>=1 && day<= days[month])
                {
                    this. day = day;
                    this.month = month;
                    this.year = year;
                }
            }


        }
        // Constructor overloading : multiple constructor with different parameters
        
        public Date( int year) : this(01,01,year)
        {
            this.year = year;
        }
        public Date(  int month,int year) : this(01,month, year)
        {
            this.year = year;
            this.month = month;
        }

        public string GetDate()
        {
            return $"{day.ToString().PadLeft(2,'0')}/{month.ToString().PadLeft(2,'0')}/{year.ToString().PadLeft(4, '0')}";

        }
    }
}
