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
        public double currentAlarmTime; // display current alarm time x
        public double setAlarm; // user ability to set alarm x
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
            Console.WriteLine("Your current alarm is set for 11:00 A.M. Would you like to change alarm time? Press 1 to change or Press 2 to keep current alarm time.");
            double.TryParse(Console.ReadLine(), out currentAlarmTime);
            if (currentAlarmTime == 1)
            {
                Console.WriteLine("What time would you like to set an alarm for?");
                Console.ReadLine();
                Console.WriteLine("Would you like to turn this alarm on? Press 1 for Yes or Press 2 for no.");
                double.TryParse(Console.ReadLine(), out setAlarm);
                if (setAlarm == 1)
                {
                    Console.WriteLine("Congrats! Your alarm has been turned on!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your 11:00A.M. alarm is been turned on!");
                }
            }
        }
    }
}
