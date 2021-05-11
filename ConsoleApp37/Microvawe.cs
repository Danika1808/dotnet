using System;


namespace ConsoleApp37
{
    public class Microvawe : IMicrovawe
    {
        public void Defrost()
        {
            StartNotification();
            MicrowavePower = 1000;
            TurlRight();
            TurlRight();
            MicrowavePower = 500;
            TurlLeft();
            TurlLeft();
            MicrowavePower = 200;
            TurlRight();
            TurlRight();
            MicrowavePower = 0;
            StopNotification();
        }

        public void Heating()
        {
            StartNotification();
            MicrowavePower = 350;
            TurlRight();
            TurlRight();
            TurlRight();
            TurlRight();
            TurlRight();
            TurlLeft();
            TurlLeft();
            TurlRight();
            TurlRight();
            TurlLeft();
            TurlLeft();
            TurlLeft();
            TurlLeft();
            MicrowavePower = 0;
            StopNotification();
        }
        private int _power;
        public int MicrowavePower
        {
            get { return _power; }
            set
            {
                _power = value;
                Console.WriteLine("Задана мощность {0}w ", _power);
            }
        }
        public void TurlLeft()
        {
            Console.WriteLine("Повернуть влево");
        }
        public void TurlRight()
        {
            Console.WriteLine("Повернуть вправо");
        }
        public void StopNotification()
        {
            Console.WriteLine("Пик-пик-пик - операция завершена");
        }
        public void StartNotification()
        {
            Console.WriteLine("Пик - начат процесс готовки");
        }
    }
}
