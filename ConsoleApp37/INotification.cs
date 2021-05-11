using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    interface INotification
    {
        public void StopNotification();
        public void StartNotification();
        public void PowerNotification(int power);
    }
}
