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
        private UnitOfWorks _unitOfWorks;

        public RandomGiftChooser(UnitOfWorks unitOfWorks)
        {
            _unitOfWorks = unitOfWorks;
        }

        public async Task GetRendomGift(decimal price, string userId)
        {
            var actualPrice = price - price * 5 / 100;
            var someGift = (from gift in _unitOfWorks.Gift.List
                            where gift.Price <= actualPrice
                            select gift).ToList();
            Random r = new Random();
            int index = r.Next(0, someGift.Count-1);
            var choosenGift = someGift[index];
            //var allPossibleReceivers = from good in _unitOfWorks.Goods.List
            //                           where good.UserId != userId
            //                           select good;
            var sendTo = (from us in _unitOfWorks.Users.List
                           where !us.Deleted && us.Id != userId
                           select us).OrderByDescending(x=>x.Rating).FirstOrDefault();

            UserRelations _relation = new UserRelations
            {
                Created = DateTime.Now,
                Deleted = false,
                DestinationId = int.Parse(sendTo.Id),
                SourceId = int.Parse(userId),
                IsSent = true
            };
            await _unitOfWorks.UserRelations.Add(_relation);

        }
    }
}
