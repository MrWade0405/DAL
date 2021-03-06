﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Implementations
{
    public class CategoriesTranslationsRepository : IRepository<CategoriesTranslations>
    {
        private LearningLanguagesContext db;

        public void Create(CategoriesTranslations item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CategoriesTranslations GetItem(int id)
        {
            return db.CategoriesTranslations.Find(id);
        }

        public IEnumerable<CategoriesTranslations> GetList()
        {
            return db.CategoriesTranslations;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(CategoriesTranslations item)
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
