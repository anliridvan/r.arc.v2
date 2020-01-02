using System.Collections.Generic;
using System.Net;
using R.ARC.Common.Helper.Models;
using Newtonsoft.Json;

namespace R.ARC.Common.Helper.Models.Exceptions
{
    public class ValidationException : ApiException<IEnumerable<ValidationError>>
    {
        public ValidationException(string message, IEnumerable<ValidationError> validationErrors) : base(
            HttpStatusCode.BadRequest, message, validationErrors ?? new List<ValidationError>())
        {
        }

        public override string GetContent()
        {
            return JsonConvert.SerializeObject(Content);
        }
    }
}