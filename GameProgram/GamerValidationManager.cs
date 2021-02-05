using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgram
{
    class GamerValidationManager : IGamerValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id==1 && gamer.FirtName=="AYŞENUR" &&gamer.LastName=="ATLAÇ" && gamer.IdentityNumber==12345 && gamer.BirthYear==2002 || 
                gamer.Id == 2 && gamer.FirtName == "ALİ" && gamer.LastName == "ATLAÇ" && gamer.IdentityNumber == 12346 && gamer.BirthYear == 1998)
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
