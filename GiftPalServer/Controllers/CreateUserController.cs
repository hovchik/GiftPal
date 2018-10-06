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
        public async Task<int> CreateUser([FromBody] Users _user)
        {
            if (_unitOfWorks.Users.List.Any(mail => mail.Email.ToLower() == _user.Email.ToLower()))
            {
                return 0;
            }
            await _unitOfWorks.Users.Add(_user);
            _unitOfWorks.Save().GetAwaiter().GetResult();
            return _unitOfWorks.Users.List.FirstOrDefault(id => id.Email == _user.Email).Id;
            // return  _unitOfWorks.Users.List.FirstOrDefault(id => id.Email == _user.Email);
        }

        [HttpGet("{Id}")]
        public Users Get(int Id)
        {
            return _unitOfWorks.Users.List.FirstOrDefault(x => x.Id == Id);
        }

        [HttpPost]
        public async Task<bool> CreateShippingAddressPost([FromBody] ShippingAddress _address)
        {
            if (_unitOfWorks.ShippingAddress.List.Any(ad => ad.UserId == _address.UserId))
            {
                return false;
            }
            await _unitOfWorks.ShippingAddress.Add(_address);
            await _unitOfWorks.Save();
            return true;
        }
    }
}