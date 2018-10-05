using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace GiftPalServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateUserController : ControllerBase
    {
        private UnitOfWorks _unitOfWorks;

        public CreateUserController(UnitOfWorks unitOfWorks)
        {
            _unitOfWorks = unitOfWorks;
        }
        [HttpPost]
        public async Task<bool?> CreateUserPost([FromBody] Users user)
        {
            return null;
        }
    }
}