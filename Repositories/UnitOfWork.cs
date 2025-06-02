using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;

namespace api.Repositories
{
    public class UnitOfWork
    {
        private readonly EmprestaAiDbContext _context;
        public UnitOfWork(EmprestaAiDbContext context)
        {
            _context = context;
        }
        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}