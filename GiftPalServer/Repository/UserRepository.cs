using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;
using Models;

namespace GiftPalServer.Repository
{
    public class UserRepository:IRepository<Users>
    {
        private GiftPalDbContext db;

        public UserRepository(GiftPalDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Users> List { get; }
        public void Add(Users entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Users entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Users entity)
        {
            throw new NotImplementedException();
        }

        public Users FindById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
