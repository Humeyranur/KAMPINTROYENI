using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        //field tanımlama
        public string Country;

        //property tanımlama
        public int Id { get; set; }

        private string _firstName;
        public string FirstName //eğer kullanıcı firstname i set ederse yani bir değer verirse başına başka bir karakter gelsin 
                                //mesela Ms. gibi bunu yapabilmek için get bloğu biraz daha açık yazılmalı. Bunu şu şekilde yaparız;(ÇOK KULLANILMAZ)
        {
            get { return "Mrs."+ _firstName; }    
            
            set { _firstName = value;}
         }  
        
        public string LastName { get; set; }

        public string City { get; set; }



    }
}
