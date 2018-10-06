using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;
using Microsoft.EntityFrameworkCore;
using Models;

namespace GiftPalServer.Repository
{
    public class ToSendRepository:IRepository<ToSend>
    {
        private GiftPalDbContext db;

        public ToSendRepository(GiftPalDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<ToSend> List => db.ToSends;
        public async Task Add(ToSend entity)
        {
            await db.ToSends.AddAsync(entity);
        }

        public void Delete(ToSend entity)
        {
            db.ToSends.Remove(entity);
        }

        public void Update(ToSend entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public async Task<ToSend> FindById(int Id)
        {
            return await db.ToSends.FindAsync(Id);
        }
    }
}
