using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concreate
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
            if (_userValidationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " oyuncusu eklendi" + '\n');
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt Başarısız." + '\n');
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "oyuncusu silindi");
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " oyuncusu güncellendi" + '\n');
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt Başarısız." + '\n');
            }
        }
    }
}
