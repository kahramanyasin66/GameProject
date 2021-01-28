using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(":) Tebrikler  == Kayıt Başarılı ");
            }
            else
            {
                Console.WriteLine(":( Tekrar Deneyiniz  == Kayıt Başarısız !");
            }
           
        }       

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

     

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
