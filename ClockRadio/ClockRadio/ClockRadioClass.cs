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
        public double setAlarm; // user ability to set alarm and turn it on or off x
        public double radioStation; // dipslay current radio station x
        public double changeRadioStation; // ability to change the radio station


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
                else if (setAlarm == 2)
                {
                    Console.WriteLine("Your alarm is now turned off!");
                    Console.ReadLine();
                }
            }
            else if (currentAlarmTime == 2)
            {
                Console.WriteLine("Would you like to turn your 11:00A.M. alarm on? Press 1 for Yes or 2 for No.");
                double.TryParse(Console.ReadLine(), out setAlarm);
                if (setAlarm == 1)
                {
                    Console.WriteLine("Congrats! Your alarm has been turned on!");
                    Console.ReadLine();
                }
                else if (setAlarm == 2)
                {
                    Console.WriteLine("Your alarm is now turned off!");
                    Console.ReadLine();
                }
            }
        }
        public void RadioStation()
        {
            Console.WriteLine("You're currently listing to 100.8 DevCode focus beats! Would you like to change the radio station? If yes press 1 if no press 2!");
            double.TryParse(Console.ReadLine(), out radioStation);
            if (radioStation == 1)
            {
                Console.WriteLine("Great! What station would you like to listen to? Press 1 for DevCode InTheZone beats, 2 for LetsGetToWork.DevCodeFM, 3 for random.");
                double.TryParse(Console.ReadLine(), out changeRadioStation);
                if (changeRadioStation == 1)
                {
                    Console.WriteLine("You are now listing to DevCode InTheZOne beats!");
                    Console.ReadLine();
                }
                else if (changeRadioStation == 2)
                {
                    Console.WriteLine("You are now listing to LetsGetToWork.DevCodeFM!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You are now listing to LowFi hip-hop!");
                    Console.ReadLine();
                }

            }
        }
    }
}
