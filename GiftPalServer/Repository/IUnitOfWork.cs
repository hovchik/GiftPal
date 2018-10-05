using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftPalServer.Repository
{
    public interface IUnitOfWork
    {
        GiftsRepository Gift { get; }
        GoodsRepository Goods { get; }
        FeedbackRepository Feedback { get; }

        ReceivedGoodsRepository ReceivedGoods { get; }

        SentGoodsRepository SentGoods { get; }
        ShippingAddressRepository ShippingAddress { get; }
        UserRelationsRepository UserRelations { get; }
        UserRepository Users { get; }
        Task Save();
    }
}
