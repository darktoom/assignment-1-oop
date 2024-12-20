using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace assignment_1
{
    public struct Person
    {
        public string Name;
        public int Age;

       
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        
        public  void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

    }
}
