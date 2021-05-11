using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Drive : IDrive
    {
        public void TurlLeft()
        {
            Console.WriteLine("Повернуть влево");
        }
        public void TurlRight()
        {
            Console.WriteLine("Повернуть вправо");
        }
    }
}
