using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class Program
    {
        public static void Main(string[] args)
        {
            ClockRadioClass ClockRadioClass = new ClockRadioClass();
            ClockRadioClass.CurrentTime();
            ClockRadioClass.CurrentAlarm();
            ClockRadioClass.RadioStation();
        }
    }
}
