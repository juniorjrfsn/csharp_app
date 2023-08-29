using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2DAL.Ancient
{
    public abstract class Repository<TContext, TEntity> : IRepository<TEntity> 
        where TEntity : class
        where TContext : DbContext
    {
        private TContext dataContext;

        public TContext DataContext 
        { 
            get { return this.dataContext; } 
        }

        public Repository(TContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Create(TEntity instance)
        {
            this.dataContext.Set<TEntity>().Add(instance);
        }

        public IQueryable<TEntity> ReadAll()
        {
            return this.dataContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> ListAll()
        {
            return this.dataContext.Set<TEntity>().AsEnumerable();
        }

        public TEntity Read(int key)
        {
            return this.dataContext.Set<TEntity>().Find(key);
        }

        public void Update(TEntity instance)
        {
            this.dataContext.Entry(instance).State = EntityState.Modified;
        }

        public void Delete(TEntity instance)
        {
            this.dataContext.Entry(instance).State = EntityState.Deleted;
        }

        public void Delete(int key)
        {
            TEntity instance = this.Read(key);
            this.Delete(instance);
        }

        public int SaveChanges()
        {
            return this.dataContext.SaveChanges();
        }
    }
}
