using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales
{
    class PaymentValidationManager : IPaymentValidationService
    {
        
        public bool PayValidate(Game game)
        {
            if (game.GameName == "PubG" && game.Id ==1 && game.Price==45 && game.Company =="Unity" )
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
