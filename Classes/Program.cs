using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();   //classı kullanabilmek için örneğini oluşturduk ve metodu çağırdık.


            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara"; //set bloğu çalışır.
            customer.Id = 1;
            customer.FirstName = "Hümeyra Nur";
            customer.LastName = "Turgut";

            Customer customer2 = new Customer  // bu şekilde de class oluşturulabilir.
            {
                City = "Ankara", Id = 1,FirstName = "Hasan",LastName = "Turgut"
            };
            Console.WriteLine(customer2.FirstName); //get bloğu çalışır.
        }
    }


    class CustomerManager
    {
         public void Add()       //buraya müşteri ile ilgili işlemler konulabilir.
        {
            Console.WriteLine("Customer Added");
        }
 
        public void Update()
        {
             Console.WriteLine("Customer Updated");
        }
    } 

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added");
        }

        public void Update()
        {
             Console.WriteLine("Product Updated");
        }
    }

}
// aynı projede tutulabileceği gibi proje üzerine sağ tıklanarak ayrı ayrı da tutulabilirler.