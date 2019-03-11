using Domain.UseCases.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ReadUserRequest = Domain.UseCases.Users.Read.Request;
using ReadUserResponse = Domain.UseCases.Users.Read.Response;

namespace WebInterface.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUseCase<ReadUserRequest, ReadUserResponse> _readUserUseCase;

        public HomeController(IUseCase<ReadUserRequest, ReadUserResponse> readUserUseCase)
        {
            _readUserUseCase = readUserUseCase;
        }

        public async Task<IActionResult> Index()
        {
            var request = new ReadUserRequest
            {
                UserId = "1232131"
            };

            var user = await _readUserUseCase.Execute(request);

            return View(user);
        }
    }
}