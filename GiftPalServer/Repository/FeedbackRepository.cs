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

        public IEnumerable<Feedbacks> List => db.Feedbacks;
        public void Add(Feedbacks entity)
        {
            db.Feedbacks.Add(entity);
        }

        public void Delete(Feedbacks entity)
        {
            db.Feedbacks.Remove(entity);
        }

        public void Update(Feedbacks entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public Feedbacks FindById(int Id)
        {
            return db.Feedbacks.Find(Id);
        }
    }
}
