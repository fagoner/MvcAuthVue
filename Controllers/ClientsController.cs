using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcAuthVue.Models;

namespace MvcAuthVue.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientsController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public List<Client> GetClientes()
        {
            return new List<Client>() {
                new Client {Id = 1, Name = "Alfa"},
                new Client {Id = 2, Name = "Vega"}
            };
        }

    }
}