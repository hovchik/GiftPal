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
        

      

        // POST: api/SendGift
        [HttpPost]
        public async Task Post(decimal money, int userid)
        {
            await _chooser.GetRendomGift(money, userid);
            await _unitOfWorks.Save();

        }

    }
}
