using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet
    class Product //entity-- bu tip classlarda sadece özellik olur.
    {
        public int Id { get; set; } //primary key 1. sıra
        public int CategoryId { get; set; } //foreign key 2. sıra
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //CRUD create read update delete operasyonları
    }
}
