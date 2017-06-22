using Microsoft.AspNetCore.Mvc;

namespace Fiver.Mvc.ModelBinding.Models.Home
{
    public class HeaderInputModel
    {
        [FromHeader]
        public string Host { get; set; }

        [FromHeader(Name = "User-Agent")]
        public string UserAgent { get; set; }
    }
}
