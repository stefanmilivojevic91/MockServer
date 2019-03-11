using Domain.Interfaces.Repositories;
using Domain.UseCases.Shared;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.UseCases.Users.Read
{
    public class ReadUserUseCase : IUseCase<Request, Response>
    {
        private readonly IUserRepository _userRepository;

        public ReadUserUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Response> Execute(Request request)
        {
            var user = await _userRepository.GetById(request.UserId);

            return new Response
            {
                UserInfo = new Dtos.User.UserInfoDto
                {
                    UserId = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName
                },
                Applications = user.Applications.Select(application => new Dtos.Application.ApplicationInfoDto { Id = application.Id, Name = application.Name })
            };
        }
    }
}
