﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class WordTranslationsRepository : IRepository<WordTranslations>
    {
        private LearningLanguagesContext db;

        public void Create(WordTranslations item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public WordTranslations GetItem(int id)
        {
            return db.WordTranslations.Find(id);
        }

        public IEnumerable<WordTranslations> GetList()
        {
            return db.WordTranslations;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(WordTranslations item)
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
