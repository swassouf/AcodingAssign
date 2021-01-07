using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerPublication;
using CustomerPublication.Services;
using Microsoft.AspNetCore.Routing;

namespace AcodingAssign.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicationController : ControllerBase
    {

        private readonly IPublicationService _publicationService;

        public PublicationController(IPublicationService publicationService)
            => _publicationService = publicationService;

        [HttpPost]
        [Route("CreatePublication")]
        public Result<string> CreatePublication(Publication publication)
        {
         var result =   _publicationService.SavePublication(new List<Publication>( ){publication});

         return result;
        }
    }
}
