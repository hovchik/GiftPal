using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;
using Microsoft.EntityFrameworkCore;
using Models;

namespace GiftPalServer.Repository
{
    public class GoodsRepository:IRepository<Goods>
    {
        private GiftPalDbContext db;

        public GoodsRepository(GiftPalDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Goods> List => db.Goods;
        public async Task Add(Goods entity)
        {
           await db.Goods.AddAsync(entity);
        }

        public void Delete(Goods entity)
        {
            db.Goods.Remove(entity);
        }

        public void Update(Goods entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public async Task<Goods> FindById(int Id)
        {
            return await db.Goods.FindAsync(Id);
        }
    }
}
