using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;
using Microsoft.EntityFrameworkCore;
using Models;

namespace GiftPalServer.Repository
{
    public class ReceivedGoodsRepository : IRepository<ReceivedGoods>
    {
        private GiftPalDbContext db;

        public ReceivedGoodsRepository(GiftPalDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<ReceivedGoods> List => db.ReceivedGoods;
        public void Add(ReceivedGoods entity)
        {
            db.ReceivedGoods.Add(entity);
        }

        public void Delete(ReceivedGoods entity)
        {
            db.ReceivedGoods.Remove(entity);
        }

        public void Update(ReceivedGoods entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public ReceivedGoods FindById(int Id)
        {
            return db.ReceivedGoods.Find(Id);
        }
    }
}
