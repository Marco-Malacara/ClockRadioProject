using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    public class ClockRadioClass
    {
        public DateTime currentTime; //Display Current Time X 
        public double currentAlarmTime; // display current alarm time
        public bool alarmOnOff; //turn alarm on and off
        public double changeRadioStation; // dipslay current radio station / change radio station

        public void CurrentTime()
        {
            currentTime = DateTime.UtcNow;
            Console.WriteLine("Your current date and time is " + currentTime);
            Console.ReadLine();
        }    
        public void CurrentAlarm()
        {
            Console.WriteLine("Your current alarm is set for 11:00 A.M. Would you like to turn this alarm on/off? Press 1 for ON or Press 2 for OFF.");
            double.TryParse(Console.ReadLine(), out currentAlarmTime);
            if(currentAlarmTime == 1)
            {
                Console.WriteLine("Your 11:00 A.M. alarm is now turned on!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your 11:00 A.M. alarm has been turned off!");
                Console.ReadLine();
            }
        }
    }
}
