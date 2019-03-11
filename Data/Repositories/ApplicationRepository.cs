using Domain.BussinesEntities;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ApplicationRepository : IApplicationRepository
    {
        public Task<Application> GetById(int applicationId)
        {
            throw new NotImplementedException();
        }
    }
}
