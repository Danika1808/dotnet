using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    interface IMicrovawe
    {
        public void Defrost();
        public void Heating();
        public void TurlLeft();
        public void TurlRight();
        public void StopNotification();
        public void StartNotification();

    }
}
