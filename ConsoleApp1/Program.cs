using lib.Barcode.Type;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Code128 code128 = new Code128("test taaa", Code128.CODESET.B);
            Console.WriteLine(code128.GetCode128String);

            Code128 code128w = new Code128("test taaa", Code128.CODESET.B, Code128.RETURNCOLUMN.Widths);
            Console.WriteLine(code128w.GetCode128String);
        }
    }
}
