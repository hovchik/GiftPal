using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.Repository;
using Models;

namespace GiftPalServer.Processing
{
    public class RandomGiftChooser
    {
        private IUnitOfWork _unitOfWorks;

        public RandomGiftChooser(IUnitOfWork unitOfWorks)
        {
            _unitOfWorks = unitOfWorks;
        }

        public async Task GetRendomGift(decimal price, int userId)
        {
            var actualPrice = price - price * 5 / 100;
            var someGift = (from gift in _unitOfWorks.Gift.List
                            where gift.Price <= actualPrice
                            select gift).ToList();
            Random r = new Random();
            int index = r.Next(0, someGift.Count - 1);
            var choosenGift = someGift[index];
            var sendTo = (from us in _unitOfWorks.Users.List
                          where !us.Deleted && us.Id != userId
                          select us).OrderByDescending(x => x.Rating).FirstOrDefault();


            ToSend sentobj = new ToSend
            {
                DestinationId = sendTo.Id,
                SourceId = userId,
                GiftId = choosenGift.Id,
                IsSending = true
            };
           
            await _unitOfWorks.ToSends.Add(sentobj);

        }


    }
}
