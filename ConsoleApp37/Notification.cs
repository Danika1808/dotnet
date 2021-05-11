using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Notification : INotification
    {
        public void StopNotification()
        {
            Console.WriteLine("Пик-пик-пик - операция завершена");
        }
        public void StartNotification()
        {
            Console.WriteLine("Пик - начат процесс готовки");
        }

        public void PowerNotification(int power)
        {
            Console.WriteLine($"Задана мощность {power}");

        }
    }
}
