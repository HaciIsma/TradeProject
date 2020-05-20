using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TradeProject.Data;
using TradeProject.Model;
using TradeProject.Repository.Interface;

namespace TradeProject.Repository
{
    public class StorageProductRepo : IRepoProducts<StorageProduct>
    {
        private readonly DBContext<StorageProduct> _context;
        public StorageProductRepo(DBContext<StorageProduct> context)
        {
            _context = context;

            using (var db = _context)
            {
                db.Database.EnsureCreated();
            }
        }
        public void Add(StorageProduct entity)
        {
            using (var db = _context)
            {
                db.Entities.Add(entity);
            }
        }
        public List<StorageProduct> GetAll()
        {
            using (var db = _context)
            {
                return db.Entities.ToList();
            }
        }
        public void Remove(Expression<Func<StorageProduct, bool>> filter)
        {
            using (var db = _context)
            {
                db.Entities.Remove(db.Entities.FirstOrDefault(filter));
            }
        }
        public void Update(StorageProduct entity)
        {
            //* Wtf
            using (var db = _context)
            {
                db.Entities.Update(entity);
            }
        }
    }
}
