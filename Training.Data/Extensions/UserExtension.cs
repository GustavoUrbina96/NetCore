using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Extensions
{
    public static class UserExtension
    {
        public static DTO.User ToDTO(this Models.User u)
        {
            return new DTO.User
            {
                Id = u.Id,
                FullName = u.FullName
                //Created_at = u.Created_at,
                //Country_code = u.Country_code
            };
        }

        public static Models.User ToDatabaseModel(this DTO.User u)
        {
            return new Models.User
            {
                Id = u.Id,
                FullName = u.FullName
                //Created_at = u.Created_at,
                //Country_code = u.Country_code

            };
        }
    }
}
