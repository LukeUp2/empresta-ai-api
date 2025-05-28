using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class EmprestaAiDbContext : DbContext
    {
        public EmprestaAiDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}