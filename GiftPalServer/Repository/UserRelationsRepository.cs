using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<UserRelations> List => db.UserRelations; 
        public async Task Add(UserRelations entity)
        {
           await db.UserRelations.AddAsync(entity);
        }

        public void Delete(UserRelations entity)
        {
            db.UserRelations.Remove(entity);
        }

        public void Update(UserRelations entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public async Task<UserRelations> FindById(int Id)
        {
            return await db.UserRelations.FindAsync(Id);
        }
    }
}
