using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Exceptions
{
    public class ErrorOnValidationException : EmprestaAiException
    {
        public List<string> ErrorMessages { get; set; }
        public ErrorOnValidationException(List<string> errorMessages) : base(string.Empty)
        {
            ErrorMessages = errorMessages;
        }
    }
}