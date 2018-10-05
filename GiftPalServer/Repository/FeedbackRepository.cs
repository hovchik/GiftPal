using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;
using Models;

namespace GiftPalServer.Repository
{
    public class FeedbackRepository:IRepository<Feedbacks>
    {
        private GiftPalDbContext db;

        public FeedbackRepository(GiftPalDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Feedbacks> List { get; }
        public void Add(Feedbacks entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Feedbacks entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Feedbacks entity)
        {
            throw new NotImplementedException();
        }

        public Feedbacks FindById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
