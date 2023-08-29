using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2DAL.Ancient
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity instance);

        IQueryable<TEntity> ReadAll();

        IEnumerable<TEntity> ListAll();

        TEntity Read(int key);

        void Update(TEntity instance);

        void Delete(TEntity instance);

        void Delete(int key);
    }
}
