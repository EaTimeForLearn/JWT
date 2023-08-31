using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtNewProje.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username="Emre", EmailAddress="emre@mail.com", Address="Bornova",Password="emre1234", Role="Admin", Surname="Akar"  },
            new UserModel() { Username="Ata", EmailAddress="ata@mail.com", Address="Karşıyaka",Password="ata1234", Role="Seller", Surname="Koç"  }

        };
    }
}
