using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class TestsRepository : IRepository<Tests>
    {
        private LearningLanguagesContext db;

        public void Create(Tests item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Tests GetItem(int id)
        {
            return db.Tests.Find(id);
        }

        public IEnumerable<Tests> GetList()
        {
            return db.Tests;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Tests item)
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
