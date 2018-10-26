using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Course
    {
        private string name;
        private int duration;
        public string Name { get { return name; } set { name = value; } }
        public int DurationInMinutes { get { return duration; } set { duration = value; } }
       
        
        public Course(string name, int duration)
        {
            Name = name;
            DurationInMinutes = duration;
        }
        public Course(string name) : this (name, 0) { }
        public override string ToString()
        {
            return $"Name: {name}, Duration in Minutes: {duration}";
        }

    }
}
