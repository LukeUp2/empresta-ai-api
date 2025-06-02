using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;

namespace api.Repositories
{
    public class UserRepository
    {
        private readonly EmprestaAiDbContext _dbContext;
        public UserRepository(EmprestaAiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Entities.User user)
        {
            await _dbContext.AddAsync(user);
        }

        public bool CheckIfEmailAlreadyExists(string email)
        {
            return false;
        }
    }
}