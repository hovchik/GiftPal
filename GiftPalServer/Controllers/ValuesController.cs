using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.Repository;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace GiftPalServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IUnitOfWork _unitOfWorks;

        public ValuesController(IUnitOfWork unitOfWorks)
        {
            _unitOfWorks = unitOfWorks;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "Welcome to GiftPal";
        }

        // GET api/values/5
       
    }
}
