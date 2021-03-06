﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class UsersRepository : IRepository<Users>
    {
        private LearningLanguagesContext db;

        public void Create(Users item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Users GetItem(int id)
        {
            return db.Users.Find(id);
        }

        public IEnumerable<Users> GetList()
        {
            return db.Users;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Users item)
        {
            throw new NotImplementedException();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
