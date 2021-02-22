using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer 
            { 
                Id = 1,
                BirthYear=1985,
                FirstName ="HÜMEYRA NUR", 
                LastName ="TURGUT", 
                IdentityNumber=12345  
            });

            //GamerManager gamerManager1 = new GamerManager(new NewEStateUserValidationManager());   yeni bir doğrulama sistemine geçildiği varsayılırsa sistem hiç bozulmadan bazı eklemeler ile kullanıma devam edilebilir.
            //gamerManager1.Add(new Gamer
            //{
            //    Id = 1,
            //    BirthYear = 1985,
            //    FirstName = "HÜMEYRA NUR",
            //    LastName = "TURGUT",
            //    IdentityNumber = 12345
            //});

        }
    }
}
