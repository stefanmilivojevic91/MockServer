using System;
using System.Collections.Generic;
using System.Text;
using dtos = Domain.UseCases.Dtos;

namespace Domain.UseCases.Applications.Read
{
    public class Response
    {
        public dtos.Application.ApplicationInfoDto Application { get; set; }
        public IEnumerable<dtos.Routes.Route> Routes { get; set; }
    }
}
