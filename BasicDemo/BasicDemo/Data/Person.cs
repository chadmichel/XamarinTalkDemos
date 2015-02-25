using System;

namespace BasicDemo
{
    public class Person
    {
        public Person()
        {
        }

        public string Name {get;set;}
        public int Age {get;set;}

        public override string ToString()
        {
            return Name;
        }
    }
}

