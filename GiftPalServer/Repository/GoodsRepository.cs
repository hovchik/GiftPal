using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;
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

        public IEnumerable<Goods> List { get; }
        public void Add(Goods entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Goods entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Goods entity)
        {
            throw new NotImplementedException();
        }

        public Goods FindById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
