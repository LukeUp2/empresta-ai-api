using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Entities
{
    public class AuditLog
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}