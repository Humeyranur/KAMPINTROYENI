using System;

namespace Interface2
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface new'lemez.
            // IPersonManager personManager = new IPersonManager();
            // personManager.Add();

            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
        }
    }

    class PersonManager
    {
        
        //implemented operation
        public void Add()
        {
            Console.WriteLine("Eklendi");
        }
    }

    interface IPersonManager
    {
        //unimplemented operation
        void Add();  // dışarıdan da erişilebilir olması için  default olmalı.
        void Update();
    }

    
   // inherits - class    interface- implements

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
        
    }

    class ProjectManager  //ister personel ister müşteri ekleme simülasyonu
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
