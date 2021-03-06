﻿using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
         Person person1 = new Person();
         Person person2 = new Person();
         person1.FirstName = "Engin";

            person2 = person1;
            person1.FirstName = "Derin";

            Console.WriteLine(person2.FirstName );


            Customer customer = new Customer();
            customer.FirstName = "salih";
            customer.CreditCardNumber = "11234567654";

            Employee employee = new Employee();
            employee.FirstName = "veli";

            Person person3 = customer;  // inharitance yaptığımız için customer ı person a atayabildik.
            customer.FirstName = "ahmet";

            Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);


            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
        }
    }


class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
    //base class= person
class Customer :Person //inheritance
{
    public string CreditCardNumber { get; set; }
}

class Employee : Person //inheritance
{
    public int EmployeeNumber { get; set; }
}
    class PersonManager
    {
        public void Add (Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}