using Domain.BussinesEntities;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<User> GetById(string userId)
        {
            var user = new User
            {
                Id = Guid.NewGuid().ToString(),
                Email = "stefca.milivojevic@gmail.com",
                FirstName = "Stefan",
                LastName = "Milivojevic",
                Applications = new List<Application>
                {
                    new Application
                    {
                        Id = 1,
                        Name = "App1"
                    },
                    new Application
                    {
                        Id = 2,
                        Name = "App2"
                    },
                    new Application
                    {
                        Id = 3,
                        Name = "App3"
                    }
                }
            };

            return Task.FromResult(user);
        }
    }
}
