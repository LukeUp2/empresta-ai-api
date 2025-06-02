using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Entities;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class EmprestaAiDbContext : DbContext
    {
        public EmprestaAiDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
    }
}