
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_MVC.RepositoryPattern
{
    public class EFCoreRepos<T> : IRepository<T> where T : class
    {

        protected readonly DbContext _Context;

        public EFCoreRepos(DbContext Context) => _Context = Context;


        public virtual void Delete<PType>(PType id)
        {
           var existingentity =  _Context.Set<T>().Find(id);

            if(existingentity is not null)
            {
                _Context.Set<T>().Remove(existingentity);
                _Context.SaveChanges();

            }


        }

        public  async virtual Task DeleteAsync<PType>(PType id)
        {
            var existingEntity = await _Context.Set<T>().FindAsync(id);

            if (existingEntity is not null)
            {
                _Context.Set<T>().Remove(existingEntity);
                await _Context.SaveChangesAsync();
            }
        }

        public virtual List<T> Filter(Func<T, bool> filterPredicate)
        {
            return _Context.Set<T>().Where(filterPredicate).ToList();
        }

        public virtual Task<List<T>> FilterAsync(Func<T, bool> filterPredicate)
        {
            return Task.FromResult(_Context.Set<T>().Where(filterPredicate).ToList());
        }

        public virtual List<T> GetAll() => _Context.Set<T>().ToList();




        public virtual Task<List<T>> GetAllAsync() => _Context.Set<T>().ToListAsync();
        

        public T? GetDetails<PType>(PType id) => _Context.Set<T>().Find(id);
        

        public async virtual Task<T?> GetDetailsAsync<PType>(PType id) => await _Context.Set<T>().FindAsync(id);


        public virtual void Insert(T Entity)
        {
            _Context.Set<T>().Add(Entity);
            _Context.SaveChanges();
          
        }

        public virtual Task InsertAsync(T Entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Update<PType>(PType id, T Entity)
        {
            var existingentity = _Context.Set<T>().Find(id);

            if(existingentity is not null)
            {
                _Context.Entry(existingentity).CurrentValues.SetValues(Entity);
                _Context.SaveChanges();
            }

        }

        public async virtual Task UpdateAsync<PType>(PType id, T Entity)
        {
            var existingentity = await _Context.Set<T>().FindAsync(id);

            if (existingentity is not null)
            {
                _Context.Entry(existingentity).CurrentValues.SetValues(Entity);
               await  _Context.SaveChangesAsync();
            }

        }
    }
}
