using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.Repository;
using Microsoft.AspNetCore.SignalR;

namespace GiftPalServer.Hubs
{
    public class NotificationHub : Hub
    {
        private readonly ToSendRepository _repository;

        public NotificationHub(ToSendRepository repository)
        {
            _repository = repository;
        }

        public async Task NotifyAboutGift(int userid, int giftId)
        {
            var gift = await _repository.FindById(giftId);
            await Clients.All.SendAsync("UpdateCatalog", gift);
        }
    }
}
