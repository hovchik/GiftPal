using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;
using Models;

namespace GiftPalServer.Repository
{
    public class ShippingAddressRepository:IRepository<ShippingAddress>
    {
        private GiftPalDbContext db;

        public ShippingAddressRepository(GiftPalDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<ShippingAddress> List { get; }
        public void Add(ShippingAddress entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ShippingAddress entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ShippingAddress entity)
        {
            throw new NotImplementedException();
        }

        public ShippingAddress FindById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
