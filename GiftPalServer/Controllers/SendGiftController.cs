using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.Processing;
using GiftPalServer.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GiftPalServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendGiftController : ControllerBase
    {
        private IUnitOfWork _unitOfWorks;
        private RandomGiftChooser _chooser;
        public SendGiftController(IUnitOfWork unitOfWorks)
        {
            _unitOfWorks = unitOfWorks;
            _chooser = new RandomGiftChooser(unitOfWorks);
        }

        // GET: api/SendGift
        [HttpGet]
        public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2" };
        }

        // GET: api/SendGift/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SendGift
        [HttpPost]
        public async Task Post([FromBody] decimal money, int userid)
        {
            await _chooser.GetRendomGift(money, userid);
            await _unitOfWorks.Save();

        }

        // PUT: api/SendGift/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
