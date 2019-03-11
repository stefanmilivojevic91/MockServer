using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCases.Dtos.Routes
{
    public class Route
    {
        public string Url { get; set; }
        public string Method { get; set; }
        public string Response { get; set; }
        public string ContentType { get; set; }
    }
}
