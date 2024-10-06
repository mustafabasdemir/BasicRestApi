using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RestApi.Data;

namespace RestApi.Repository
{
    public class EfRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<T> _dbset;

        public EfRepository(DatabaseContext context)
        {
            _context = context;
            _dbset =_context.Set<T>();
        }

        public T Add(T entity)
        {
            var result = new T();
            _dbset.Add(entity);  //gelen modelin içine gelen entity ekle 
            _context.SaveChanges(); 
            result = entity;
            return result;
        }

        public T Delete(T entity)
        {
            var result = new T();
            _dbset.Remove(entity);
            _context.SaveChanges(); 
            result = entity;
            return result;
        }

        public List<T> GetAll()
        {
            var result = new List<T>();
            var list = _dbset.ToList();
            if(list != null)
                result = list;
            else
                result = null ; 
            return result;
        }

        public T GetById(int id)
        {
            var result = new T();
            result = _dbset.Find(id);
            return result;
        }

        public T UpdateById(T entity, int id)
        {
            var result = new T();
            var model = _dbset.Find(id);

            if(model == null)
                return null;
            
           // Yeni entity'den gelen değerleri model'e kopyala (manuel veya otomatik bir şekilde)
            _context.Entry(model).CurrentValues.SetValues(entity); // Modeli güncelle
            _context.SaveChanges();
            result = model;
            return result;
        }

    }
}