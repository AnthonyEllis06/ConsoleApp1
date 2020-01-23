using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class person
    {
        public String name { get; set; }
        public int age { get; set; }
        public person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public person()
        {
            name = null;
            age = 0;
        }
    }
}
