using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;
using Models;

namespace GiftPalServer.Repository
{
    public class ReceivedGoodsRepository:IRepository<ReceivedGoods>
    {
        private GiftPalDbContext db;

        public ReceivedGoodsRepository(GiftPalDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<ReceivedGoods> List { get; }
        public void Add(ReceivedGoods entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ReceivedGoods entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ReceivedGoods entity)
        {
            throw new NotImplementedException();
        }

        public ReceivedGoods FindById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
