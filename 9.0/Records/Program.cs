using System;

namespace Records
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Example-1
            var person1 = new Person1() { FirstName = "Ashish", LastName = "Rathi" };

            //Example-2 Positional Syntax
            var person2 = new Person2("Ashish", "Rathi");

            //Example-2 Positional Syntax wit Equality
            var phoneNumbers = new string[2];
            Person3 person3Obj1 = new("Nancy", "Davolio", phoneNumbers);
            Person3 person3Obj2 = new("Nancy", "Davolio", phoneNumbers);
            Console.WriteLine(person3Obj1 == person3Obj2); // output: True
            person3Obj1.PhoneNumbers[0] = "555-1234";
            Console.WriteLine(person3Obj1 == person3Obj2); // output: True
            Console.WriteLine(ReferenceEquals(person1, person2)); // output: False
        }
    }

    public record Person1
    {
        public string FirstName { get; set; } = default!; //You can slo use Init instead of set
        public string LastName { get; set; } = default!; //You can slo use Init instead of set
    }

    public record Person2(string FirstName, string LastName);

    public record Person3(string FirstName, string LastName, string[] PhoneNumbers);
}
