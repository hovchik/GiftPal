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
        public async Task Add(ReceivedGoods entity)
        {
           await db.ReceivedGoods.AddAsync(entity);
        }

        public void Delete(ReceivedGoods entity)
        {
            db.ReceivedGoods.Remove(entity);
        }

        public void Update(ReceivedGoods entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public async Task<ReceivedGoods> FindById(int Id)
        {
            return await db.ReceivedGoods.FindAsync(Id);
        }
    }
}
