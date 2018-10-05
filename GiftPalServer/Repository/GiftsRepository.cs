using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;
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

        public IEnumerable<Gifts> List { get; }
        public void Add(Gifts entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Gifts entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Gifts entity)
        {
            throw new NotImplementedException();
        }

        public Gifts FindById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
