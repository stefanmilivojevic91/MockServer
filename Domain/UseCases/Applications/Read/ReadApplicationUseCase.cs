using Domain.Interfaces.Repositories;
using Domain.UseCases.Shared;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.UseCases.Applications.Read
{
    public class ReadApplicationUseCase : IUseCase<Request, Response>
    {
        private readonly IApplicationRepository _applicationRepository;

        public ReadApplicationUseCase(IApplicationRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }

        public async Task<Response> Execute(Request request)
        {
            var application = await _applicationRepository.GetById(request.Id);

            return new Response
            {
                Application = new Dtos.Application.ApplicationInfoDto
                {
                    Id = application.Id,
                    Name = application.Name
                },
                Routes = application.Routes.Select(route => new Dtos.Routes.Route
                {
                    Url = route.Url,
                    Response = route.Response,
                    Method = route.Method,
                    ContentType = route.ContentType
                })
            };
        }
    }
}
