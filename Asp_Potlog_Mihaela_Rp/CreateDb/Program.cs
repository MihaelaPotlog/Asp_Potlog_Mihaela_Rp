using System;
using Asp_Potlog_Mihaela_Rp.Data;

namespace CreateDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using(var context = new Asp_Potlog_Mihaela_RpContext())
            {
                Console.WriteLine("hello");
            }
        }
    }
}
