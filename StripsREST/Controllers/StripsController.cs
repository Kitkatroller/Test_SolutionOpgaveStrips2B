using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StripsBL.Exceptions;
using StripsBL.Managers;
using StripsBL.Model;
using StripsREST.Mappers;
using StripsREST.Model.Output;

namespace StripsREST.Controllers
{
    [Route("api/[controller]/beheer")]
    [ApiController]
    public class StripsController : ControllerBase
    {
        private StripsManager stripsManager;
        private string url = "http://localhost:5117/api/";

        public StripsController(StripsManager stripsManager)
        {
            this.stripsManager = stripsManager;
        }
       
    }
}
