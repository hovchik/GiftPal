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
        public void Add(Goods entity)
        {
            db.Goods.Add(entity);
        }

        public void Delete(Goods entity)
        {
            db.Goods.Remove(entity);
        }

        public void Update(Goods entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public Goods FindById(int Id)
        {
            return db.Goods.Find(Id);
        }
    }
}
