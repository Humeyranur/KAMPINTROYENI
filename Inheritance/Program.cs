using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName= "Hümeyra" 
                }, 

                new Student
                {
                    FirstName= "Hasan"
                },

                new Person
                {
                    FirstName= "Esat"
                }

            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
    }

    class Person2
    {
        public int Id { get; set; }
        public string Address { get; set; }
      
    }

    class Customer: Person // inheritance kendine has özelliklerde barındırabilir.
    {
        public string City { get; set; }
    }

    class  Student : Person     // eğer Person2 eklersek hata  verir, sadece bir inheritance tanımlanabilir. 
    {
        public string Department { get; set; }
    }
}
