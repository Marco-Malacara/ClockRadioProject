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
        public bool alarm; // set alarm 
        public string currentAlarmTime; // display current alarm time
        public double changeRadioStation; // dipslay current radio station / change radio station

        public void CurrentTime()
        {
            currentTime = DateTime.UtcNow;
            Console.WriteLine("Your current date and time is " + currentTime);
            Console.ReadLine();
        }    
        public void SetAlarm()
        {
            Console.WriteLine("What time would you like to set your alarm for?");
            bool.TryParse(Console.ReadLine(), out alarm);
        }
    }
}
