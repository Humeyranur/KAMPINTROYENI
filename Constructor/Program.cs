using System;

namespace Constructor // bir classı new lediğimizde çalışan bloktur. İlk kez çalıştırdığımızda yapılandıran blok.
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() {Id=1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" }; //customer class ını kullanabilmek için newledik.
            Customer customer2 = new Customer(2, "Derin","Demiroğ","Ankara");// normal parantez içerisine parametre yazdık bunu kullanabilmek için public constructor un içinde de parametre geçmeliyiz.
            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        //default constructor = parametresi olmayan constructor, public Customer ı yazsakta yazmasakta arka planda bir constructor çalışır.

        public Customer()  //customer1 in çalışabilmesi için default yani parametresi olmayan constructor tanımlamak gerekir.
        {

        }
        public Customer(int id, string firstName, string lastName,string city)   //ctor yaz 2 kez tab a bas. metot parametreleri camel case yazılır. ilk küçük ikinci büyük
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string  FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }
    }
}
