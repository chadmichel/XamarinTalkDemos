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
        public string ImageUrl { get; set;}
        public string Notes { get; set;}

        public override string ToString()
        {
            return Name;
        }

        static Person[] people = new Person[]
            {
                new Person()
                {
                    Name = "Norm",
                    Age = 28,
                    ImageUrl = "https://avatars2.githubusercontent.com/u/2183127?v=3&s=460"                
                },
                new Person()
                {
                    Name = "Todd",
                    Age = 3500,
                    ImageUrl = "http://upload.wikimedia.org/wikipedia/en/5/56/Mr_Burns.png"                
                },
                new Person()
                {
                    Name = "Doug",
                    Age = 52,
                    ImageUrl = "http://upload.wikimedia.org/wikipedia/en/thumb/7/77/EricCartman.png/220px-EricCartman.png"
                }
            };

        public static Person[] GetSome()
        {
            return people;
        }
    }
}

