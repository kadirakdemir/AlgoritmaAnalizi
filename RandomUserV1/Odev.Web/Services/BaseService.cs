using Odev.Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Odev.Web.Services
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        public static IList<TEntity> entities = new List<TEntity>();
       
        public void Add(TEntity entity)
        {
            entities.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            entities.Remove(entity);
        }      

        public ICollection<TEntity> GetAll()
        {
            return entities;
        }

        public void Update(string id, TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}