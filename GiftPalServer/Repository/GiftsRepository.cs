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
        public async Task Add(Gifts entity)
        {
           await db.Gifts.AddAsync(entity);
        }

        public void Delete(Gifts entity)
        {
            db.Gifts.Remove(entity);
        }

        public void Update(Gifts entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public async Task<Gifts> FindById(int Id)
        {
            return  await db.Gifts.FindAsync(Id);
        }
    }
}
