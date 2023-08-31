using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTEx.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel(){Username="emre_admin",EmailAddress="emre.admin@email.com",Password="MyPass_word",GivenName="Emre",Surname="Akar",Role="Admin" },
             new UserModel(){Username="ata_seller",EmailAddress="ata.seller@email.com",Password="MyPass_word",GivenName="Ata",Surname="Koc",Role="Seller" }
        };
    }
}
