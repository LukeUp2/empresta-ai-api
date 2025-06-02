using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Requests;

namespace api.Services.Maps.User
{
    public static class UserMapper
    {
        public static Entities.User ToEntity(this CreateUserRequest request)
        {
            return new Entities.User
            {
                Name = request.Name,
                Email = request.Email,
            };
        }
    }
}