using Microsoft.AspNetCore.Mvc;
using CallApp.Aplication.Abstractions;
using CallApp.Domain.Respons.Data.Implementation;
using CallApp.Aplication.Implemetation;

namespace CallApp.Api.Controllers
{
    public class ClientController : BaseController
    {
        private readonly IClientService _clientService;
        private readonly IWyFisherService _wyFisher;

        public ClientController(IClientService clientService, IWyFisherService wyFisher)
        {
            _clientService = clientService;
            _wyFisher = wyFisher;
        }

        [HttpGet("Search")]
        public IActionResult Search()
        {
            _wyFisher.SendMessage();
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