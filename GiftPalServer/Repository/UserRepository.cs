using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Users> List => db.Users.AsEnumerable();
        public async Task Add(Users entity)
        {
            await db.Users.AddAsync(entity);
        }

        public void Delete(Users entity)
        {
            db.Users.Remove(entity);
        }

        public void Update(Users entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public async Task<Users> FindById(int Id)
        {
            return await db.Users.FindAsync(Id);
        }
    }
}
