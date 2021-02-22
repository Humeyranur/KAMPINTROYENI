using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
               new Manager(),
               new Worker(),  //çalışma emrini bütün çalışanlara verdik.
               new Robot(),

            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(), 
               new Worker(),     // yeme emrini robotlar hariç hepsine verdik.
            };

        }
    }


    //SOLID- INTERFACE SEGREGATION
    interface IWorker
    {
        void Work();
        
    }

    interface IEat
    {
        void Eat();

    }

    interface ISalary
    {
        void GetSalary();

    }


    class Manager : IWorker, IEat, ISalary  // bir class birden fazla interface i implemente eder.
    {
        public void Eat()
        {
            Console.WriteLine(" Yemek ye.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaş al");
        }

        public void Work()
        {
            Console.WriteLine("çalış");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine(" Yemek ye.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaş al");
        }

        public void Work()
        {
            Console.WriteLine("çalış");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("çalış");
        }
    }
}
