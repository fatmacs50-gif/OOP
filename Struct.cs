using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StructExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DigitalSize size = new DigitalSize(70000);

            size = size.AddKB(100);

            Console.WriteLine(size.Bit);
            Console.WriteLine(size.Byte);
            Console.WriteLine(size.KB);
            Console.WriteLine(size.MB);
            Console.WriteLine(size.GB);
            Console.WriteLine(size.TB);
        }

        struct DigitalSize
        {
            private long bit;

            public string Bit => $"{bit:N0} Bit";
            public string Byte => $"{bit / bitsInByte:N0} Byte";
            public string KB => $"{bit / bitsInKB:N0} KB";
            public string MB => $"{bit / bitsInMB:N0} MB";
            public string GB => $"{bit / bitsInGB:N0} GB";
            public string TB => $"{bit / bitsInTB:N0} TB";

            private const long bitsInBit = 1;
            private const long bitsInByte = 8;
            private const long bitsInKB = bitsInByte * 1024;
            private const long bitsInMB = bitsInKB * 1024;
            private const long bitsInGB = bitsInMB * 1024;
            private const long bitsInTB = bitsInGB * 1024;

            public DigitalSize(long initialValue)
            {
                bit = initialValue;
            }

            public DigitalSize AddBit(long value)
            {
                return Add(value, bitsInBit);
            }

            public DigitalSize AddByte(long value)
            {
                return Add(value, bitsInByte);
            }

            public DigitalSize AddKB(long value)
            {
                return Add(value, bitsInKB);
            }

            public DigitalSize AddMB(long value)
            {
                return Add(value, bitsInMB);
            }

            public DigitalSize AddGB(long value)
            {
                return Add(value, bitsInGB);
            }

            public DigitalSize AddTB(long value)
            {
                return Add(value, bitsInTB);
            }

            private DigitalSize Add(long value, long scale)
            {
                return new DigitalSize(this.bit + value * scale);
            }
        }
    }
}
