using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;
using Microsoft.EntityFrameworkCore;
using Models;

namespace GiftPalServer.Repository
{
    public class FeedbackRepository : IRepository<Feedbacks>
    {
        private GiftPalDbContext db;

        public FeedbackRepository(GiftPalDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Feedbacks> List => db.Feedbacks.AsEnumerable();

        public async Task Add(Feedbacks entity)
        {
            await db.Feedbacks.AddAsync(entity);
        }

        public void Delete(Feedbacks entity)
        {
            db.Feedbacks.Remove(entity);
        }

        public void Update(Feedbacks entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public async Task<Feedbacks> FindById(int Id)
        {
            return await db.Feedbacks.FindAsync(Id);
        }
    }
}
