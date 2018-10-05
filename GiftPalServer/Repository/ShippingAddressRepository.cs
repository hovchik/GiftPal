using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<ShippingAddress> List => db.ShippingAddresses;
        public void Add(ShippingAddress entity)
        {
            db.ShippingAddresses.Add(entity);
        }

        public void Delete(ShippingAddress entity)
        {
            db.ShippingAddresses.Remove(entity);
        }

        public void Update(ShippingAddress entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public ShippingAddress FindById(int Id)
        {
            return db.ShippingAddresses.Find(Id);
        }
    }
}
