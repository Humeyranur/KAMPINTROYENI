using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            
            
            
           // manager.Add(new Customer { Id = 1, FirstName = " Hümeyra", LastName = "Turgut", Address = "Kocaeli" });

            Customer customer = new Customer    //bu şekilde de yazılabilirdi.
            {
                Id = 1,
                FirstName = " Hümeyra",
                LastName = "Turgut",
                Address = "Kocaeli"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = " Hasan",
                LastName = "Turgut",
                Department = "Engineer"
            };
            manager.Add(customer);
            manager.Add(student); //ilk başta böyle yazınca hata verdi çünkü add metodunda customer istiyordu ama aşağıda IPerson yazınca hata vermez.




            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());   // inheritance sayesinde her duruma uyumlu hale geldi.



            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
           
            
            
            Console.ReadLine();
            
        }

    }

    interface IPerson  // soyut nesne, tek başına anlamları yoktur.
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson //somut nesne
    {                        //IPerson ı ampulden implemente et ya da public olan halini kullan.
       public int Id { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }

       public string Address { get; set; }
    }

    class Student : IPerson// somut nesne 
                           //IPerson ı ampulden implemente et ya da public olan halini kullan.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; } // ortak olmayan özelliklerde eklenebilir. customer için address gibi

    }

    class PersonManager
    {
        //bunun yerine  public void Add(Customer customer) // bir nesne de parametre olabilir.
        //Console.WriteLine(customer.FirstName); 
        public void Add(IPerson person) // implemente etmiş olduk.
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

