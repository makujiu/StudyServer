using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Study.Domain
{
    public class Course
    {
        private Course() { }
        public Course(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
    }
}
