
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales
{
    class SalesManager : ISalesService
    {
        IPaymentValidationService paymentValidationService;

        public SalesManager(IPaymentValidationService paymentValidationService)
        {
            this.paymentValidationService = paymentValidationService;
        }

        public void Sell(Game game)
        {
            if(paymentValidationService.PayValidate(game)== true)
            {
                Console.WriteLine(" :) Tebrikler Satış İşleminiz Gerçekleşti");
            }
            else
            {
                Console.WriteLine(":( Tekrar Deneyiniz !");
            }
        }
    }
}
