using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cineplex.bus
{
    public class Time
    {
        private int hours;
        private int minutes;

        public int Hours
        {
            get { return this.hours; }
            set { this.hours = value; }
        }

        public int Minutes
        {
            get { return this.minutes; }
            set { this.minutes = value; }
        }

        public Time()
        {
            this.hours = 0; this.minutes = 0;
        }

        public Time(int hours, int minutes)
        {
            this.hours = hours; 
            this.minutes = minutes;
        }

        public string GetTimeState()
        {
            string state;
            state = this.hours + ":" + this.minutes + ":00";
            return state;
        }
    }


}
