using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Person
    {
        string name;
        public Person(string name)
        {
            this.name = name;
        }
        public void Print() => Console.WriteLine($"Name: {name}");
    }
}
