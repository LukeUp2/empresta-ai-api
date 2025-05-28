using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Responses
{
    public class ResponseErrorJson
    {
        public List<string> Errors { get; set; }
        public ResponseErrorJson(List<string> errors) => Errors = errors;

        public ResponseErrorJson(string errorMessage)
        {
            Errors = [errorMessage];
        }
    }
}