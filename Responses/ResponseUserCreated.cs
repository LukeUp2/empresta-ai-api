using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Responses
{
    public class ResponseUserCreated
    {
        public string Name { get; set; } = string.Empty;
        public string? Token { get; set; }
    }
}