using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;
using Models;

namespace GiftPalServer.Repository
{
    public class SentGoodsRepository:IRepository<SentGoods>
    {
        private GiftPalDbContext db;

        public SentGoodsRepository(GiftPalDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<SentGoods> List { get; }
        public void Add(SentGoods entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SentGoods entity)
        {
            throw new NotImplementedException();
        }

        public void Update(SentGoods entity)
        {
            throw new NotImplementedException();
        }

        public SentGoods FindById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
