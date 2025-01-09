using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Assig04.Third_Project
{
    internal class Duration
    {//Hours, Minutes and Seconds.
        public int Hours { get; set; }

        public int Minutes { get; set; }

        public int Seconds { get; set; }

        public Duration(int Hours,int Minutes, int Seconds) 
        {
            this.Hours = Hours;
            this.Minutes = Minutes; 
            this.Seconds = Seconds;
        }

        public override string ToString()
        {
            return $"Hours = {Hours},Minutes = {Minutes}, Seconds = {Seconds}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            Duration duration=(Duration)obj;

            if (this.Hours==Hours ) return true;

            else
                return false;

        }
    }
}
