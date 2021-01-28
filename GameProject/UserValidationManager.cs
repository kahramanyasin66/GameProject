using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1994 && gamer.FirstName == "YASİN" && gamer.LastName == "KAHRAMAN" && gamer.IdentityNumber == 12345 && gamer.Id==1)
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
