using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TradeProject.Data;
using TradeProject.Model;
using TradeProject.Repository.Interface;

namespace TradeProject.Repository
{
    public class StoreProductRepo : IRepoProducts<StoreProduct>
    {
        private readonly DBContext<StoreProduct> _context;
        public StoreProductRepo(DBContext<StoreProduct> context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }
        public void Add(StoreProduct entity)
        {
            using (var db = _context)
            {
                db.Entities.Add(entity);
                db.SaveChanges();
            }
        }
        public StoreProduct Get(Expression<Func<StoreProduct, bool>> filter)
        {
            using (var db = _context)
            {
                return db.Entities.Where(filter).FirstOrDefault();
            }
        }
        public List<StoreProduct> GetAll()
        {
            using (var db = _context)
            {
                return db.Entities.ToList();
            }
        }
        public void Remove(Expression<Func<StoreProduct, bool>> filter)
        {
            using (var db = _context)
            {
                db.Entities.Remove(db.Entities.FirstOrDefault(filter));
            }
        }
        public void Update(StoreProduct entity)
        {
            //* Wtf
            using (var db = _context)
            {
                db.Entities.Update(entity);
                db.SaveChanges();
            }
        }
    }
}
