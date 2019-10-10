using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev.Web.Services.Interfaces
{
    public interface IBaseService<TEntity> where TEntity:class
    {
        ICollection<TEntity> GetAll();
        void Add(TEntity entity);
        void Update(string id, TEntity entity);
        void Delete(TEntity entity);
    }
}
