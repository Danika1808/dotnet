using System;

namespace ConsoleApp37
{
    class Program
    {
        static void Main()
        {
            var microwave = new Microvawe();

            Console.WriteLine("Разморозим");
            microwave.Defrost();
            Console.WriteLine();
            Console.WriteLine("Подогреем");
            microwave.Heating();
        }
    }
}
