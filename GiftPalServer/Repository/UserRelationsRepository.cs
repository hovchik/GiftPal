using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;
using Models;

namespace GiftPalServer.Repository
{
    public class UserRelationsRepository:IRepository<UserRelations>
    {
        private GiftPalDbContext db;

        public UserRelationsRepository(GiftPalDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<UserRelations> List { get; }
        public void Add(UserRelations entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserRelations entity)
        {
            throw new NotImplementedException();
        }

        public void Update(UserRelations entity)
        {
            throw new NotImplementedException();
        }

        public UserRelations FindById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
