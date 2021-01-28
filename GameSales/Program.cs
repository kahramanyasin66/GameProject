using System;

namespace GameSales
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesManager salesManager = new SalesManager(new PaymentValidationManager());
            salesManager.Sell(new Game
            {
                Id=1,
                GameName = "PubG",
                Price=45,
                Company ="Unity"
            });
        }
    }
}
