﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Implementations
{
    public class CategoriesRepository : IRepository<Categories>
    {
        private LearningLanguagesContext db;

        public CategoriesRepository()
        {
            this.db = new LearningLanguagesContext();
        }

        public void Create(Categories item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Categories GetItem(int id)
        {
            return db.Categories.Find(id);
        }

        public IEnumerable<Categories> GetList()
        {
            return db.Categories;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Categories item)
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
