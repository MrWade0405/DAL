﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class LanguagesRepository : IRepository<Languages>
    {
        private LearningLanguagesContext db;

        public void Create(Languages item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Languages GetItem(int id)
        {
            return db.Languages.Find(id);
        }

        public IEnumerable<Languages> GetList()
        {
            return db.Languages;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Languages item)
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
