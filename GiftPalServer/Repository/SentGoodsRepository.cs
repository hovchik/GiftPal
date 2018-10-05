using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;
using Microsoft.EntityFrameworkCore;
using Models;

namespace GiftPalServer.Repository
{
    public class SentGoodsRepository:IRepository<SentGoods>
    {
        private GiftPalDbContext db;

        public SentGoodsRepository(GiftPalDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<SentGoods> List => db.SentGoods;
        public async Task Add(SentGoods entity)
        {
            db.SentGoods.Add(entity);
        }

        public void Delete(SentGoods entity)
        {
            db.SentGoods.Remove(entity);
        }

        public void Update(SentGoods entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public async Task<SentGoods> FindById(int Id)
        {
            return await db.SentGoods.FindAsync(Id);
        }
    }
}
