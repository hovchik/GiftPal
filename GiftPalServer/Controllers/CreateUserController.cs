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
        private IUnitOfWork _unitOfWorks;

        public CreateUserController(IUnitOfWork unitOfWorks)
        {
            _unitOfWorks = unitOfWorks;
        }

        [HttpPost]
        public async Task CreateUser([FromBody] Users _user)
        {
            await _unitOfWorks.Users.Add(_user);
            await _unitOfWorks.Save();
        }
    }
}