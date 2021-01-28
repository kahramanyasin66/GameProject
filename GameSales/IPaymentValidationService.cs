using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales
{
    interface IPaymentValidationService
    {
        bool PayValidate(Game game);
    }
}
