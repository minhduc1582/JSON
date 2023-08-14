using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Marik_json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Marik",
                Age = 22
            };
            Console.WriteLine("Original person:");
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

            //Serialize
            string serializePerson = JsonSerializer.Serialize(person);
            Console.WriteLine("Serialize person:");
            Console.WriteLine(serializePerson);

            // Deserialize
            Person deserializePerson = JsonSerializer.Deserialize<Person>(serializePerson);
            Console.WriteLine("Deserialize person:");
            Console.WriteLine($"Name: {deserializePerson.Name},Age: {deserializePerson.Age}");

        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
