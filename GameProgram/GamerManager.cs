using System;
using System.Collections.Generic;
using System.Text;

namespace GameProgram
{
    class GamerManager : IGamerService
    {
        IGamerValidationService _gamerValidationService;

        public GamerManager(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt başarılı");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız.Lütfen bilgilerinizin doğruluğundan emin olun.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kullanıc silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı güncellendi.");
        }
    }
}
