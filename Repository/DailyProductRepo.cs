using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeProject.Data;
using TradeProject.Model;
using TradeProject.Repository.Interface;

namespace TradeProject.Repository
{
    public class DailyProductRepo : IRepoDaily<Daily>
    {
        private readonly DBContext<Daily> _context;
        public DailyProductRepo(DBContext<Daily> context)
        {
            _context = context;

            using (var db = _context)
            {
                db.Database.EnsureCreated();
            }
        }
        public void Add(Daily entity)
        {
            using (var db = _context)
            {
                db.Entities.Add(entity);
            }
        }

        public List<Daily> GetAll()
        {
            using (var db = _context)
            {
                return db.Entities.ToList();
            }
        }
    }
}
