using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;
using Microsoft.EntityFrameworkCore;
using Models;

namespace GiftPalServer.Repository
{
    public class GiftsRepository:IRepository<Gifts>
    {
        private GiftPalDbContext db;

        public GiftsRepository(GiftPalDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Gifts> List => db.Gifts;
        public void Add(Gifts entity)
        {
            db.Gifts.Add(entity);
        }

        public void Delete(Gifts entity)
        {
            db.Gifts.Remove(entity);
        }

        public void Update(Gifts entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public Gifts FindById(int Id)
        {
            return db.Gifts.Find(Id);
        }
    }
}
