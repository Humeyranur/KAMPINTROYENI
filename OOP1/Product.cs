﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet
    class Product //entity-- bu tip classlarda sadece özellik olur.
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //CRUD create read update delete operasyonları
    }
}
