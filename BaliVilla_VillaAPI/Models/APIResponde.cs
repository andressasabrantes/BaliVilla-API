using System.Net;

namespace BaliVilla_VillaAPI.Models
{
    public class APIResponde
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }
    }
}
