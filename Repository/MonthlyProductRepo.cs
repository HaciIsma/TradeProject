using System.Collections.Generic;
using System.Linq;
using TradeProject.Data;
using TradeProject.Model;
using TradeProject.Repository.Interface;

namespace TradeProject.Repository
{
    class MonthlyProductRepo : IRepoMonthly<Monthly>
    {
        private readonly DBContext<Monthly> _context;
        public MonthlyProductRepo(DBContext<Monthly> context)
        {
            _context = context;

            using (var db = _context)
            {
                db.Database.EnsureCreated();
            }
        }
        public void Add(Monthly entity)
        {
            using (var db = _context)
            {
                db.Entities.Add(entity);
            }
        }
        public List<Monthly> GetAll()
        {
            using (var db = _context)
            {
                return db.Entities.ToList();
            }
        }
    }
}
