using Microsoft.AspNetCore.Mvc;
using CallApp.Aplication.Abstractions;
using CallApp.Domain.Respons.Data.Implementation;

namespace CallApp.Api.Controllers
{
    public class ClientController : BaseController
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("Search")]
        public IActionResult Search()
        {
            var pasuxi = new DataResponse();//gamovidzaxe servisi da damibruna DataResponsi
            return Response(pasuxi);
        }
        
        [HttpGet("BaseInfo")]
        public IActionResult BaseInfo(string phoneNumber)
        {
            var result = _clientService.GetBaseInfo(phoneNumber);
            return Response(result);
        }

        [HttpGet("Info")]
        public IActionResult Info()
        {
            return Ok("Hello from client");
        }
    }
}