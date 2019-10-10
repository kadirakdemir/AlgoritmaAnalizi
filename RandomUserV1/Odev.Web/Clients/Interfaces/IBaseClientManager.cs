using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev.Web.Clients.Interfaces
{
    public interface IBaseClientManager<TEntity> where TEntity : class
    {
        TEntity GetAll();
        void Url(string baseUrl, string url);
        void Add(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id);
    }
}
