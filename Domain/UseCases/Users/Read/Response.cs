using Domain.UseCases.Applications.Read;
using Domain.UseCases.Dtos.Application;
using Domain.UseCases.Dtos.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCases.Users.Read
{
    public class Response
    {
        public UserInfoDto UserInfo { get; set; }
        public IEnumerable<ApplicationInfoDto> Applications { get; set; }
    }
}
