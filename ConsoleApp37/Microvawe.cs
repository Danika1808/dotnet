using System;


namespace ConsoleApp37
{
    public class Microvawe : IMicrovawe
    {
        private Power _power { get; set; }
        private Drive _drive { get; set; }
        private Notification _notification { get; set; }
        public Microvawe()
        {
            _power = new Power();
            _drive = new Drive();
            _notification = new Notification();
        }
        public void Defrost()
        {
            _notification.StartNotification();
            _power.GetPower(1000);
            _notification.PowerNotification(_power.MicrowavePower);
            _drive.TurlRight();
            _drive.TurlRight();
            _power.GetPower(500);
            _notification.PowerNotification(_power.MicrowavePower);
            _drive.TurlRight();
            _drive.TurlRight();
            _power.GetPower(250);
            _notification.PowerNotification(_power.MicrowavePower);
            _drive.TurlRight();
            _drive.TurlRight();
            _power.GetPower(0);
            _notification.PowerNotification(_power.MicrowavePower);
            _notification.StopNotification();
        }

        public void Heating()
        {
            _notification.StartNotification();
            _power.GetPower(350);
            _notification.PowerNotification(_power.MicrowavePower);
            _drive.TurlRight();
            _drive.TurlRight();
            _drive.TurlRight();
            _drive.TurlRight();
            _drive.TurlRight();
            _drive.TurlLeft();
            _drive.TurlLeft();
            _drive.TurlRight();
            _drive.TurlRight();
            _drive.TurlLeft();
            _drive.TurlLeft();
            _drive.TurlLeft();
            _drive.TurlLeft();
            _power.GetPower(0);
            _notification.PowerNotification(_power.MicrowavePower);
            _notification.StopNotification();
        }
    }
}
