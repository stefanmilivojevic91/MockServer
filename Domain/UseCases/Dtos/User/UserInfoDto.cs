using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCases.Dtos.User
{
    public class UserInfoDto
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
