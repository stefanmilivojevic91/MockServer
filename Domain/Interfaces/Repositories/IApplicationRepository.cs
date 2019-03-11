using Domain.BussinesEntities;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IApplicationRepository
    {
        Task<Application> GetById(int applicationId);
    }
}