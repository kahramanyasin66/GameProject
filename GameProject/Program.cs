using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer {
            Id=1,
            BirthYear=1994,                
            FirstName="YASİN",
            LastName= "KAHRAMAN",   
            IdentityNumber = 12345            
            });

            SalesManager salesManager = new SalesManager(new PaymentValidationManager());
            salesManager.Sell(new Game
            {
                Id = 2,
                GameName = "PubG",
                Price = 45,
                Company = "Unity"
            });
        }
    }
}
