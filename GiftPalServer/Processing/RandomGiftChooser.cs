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
            //var allPossibleReceivers = from good in _unitOfWorks.Goods.List
            //                           where good.UserId != userId
            //                           select good;
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
            //UserRelations _relation = new UserRelations
            //{
            //    Created = DateTime.Now,
            //    Deleted = false,
            //    DestinationId = sendTo.Id,
            //    SourceId = userId,
            //    IsSent = true,
            //    Good = new Goods
            //    {
            //        SentGoods = new SentGoods
            //        {
            //            Gift = choosenGift,
            //            IsSent = true
            //        }
            //    }
            //};
            await _unitOfWorks.ToSends.Add(sentobj);

        }
    }
}
