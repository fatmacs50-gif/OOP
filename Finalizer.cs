using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalizer
{
    internal class Program
    {
        static void Main(string[] args)

        {
            MakeSomeGarbage();
            Console.WriteLine($"Memory Used Before Cleaning : {GC.GetTotalMemory(false): N0}");
            GC.Collect();
            Console.WriteLine( $"Memory  Used After Cleaning : { GC.GetTotalMemory(true): N0}");

        }

            static void MakeSomeGarbage()

            {
                Version v; // دا كلاس اصلا ف الدوت نت وعملت منه اوبجكت 

                for (int i = 0; i < 1000; i++)
                {
                    v = new Version();
                }



            }
        
    }
}
