using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Enums;

namespace api.Entities
{
    public class Loan
    {
        public Guid Id { get; set; }
        public long ItemId { get; set; }
        public Guid FromUserId { get; set; }
        public Guid ToUserId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public LoanStatusEnum LoanStatus { get; set; } = LoanStatusEnum.Pending;
        public LoanReturnDateStatus ReturnDateStatus { get; set; } = LoanReturnDateStatus.OnTime;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}