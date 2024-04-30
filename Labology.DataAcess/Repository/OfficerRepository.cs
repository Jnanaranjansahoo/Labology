using Labology.DataAcess.Data;
using Labology.DataAcess.Repository.IRepository;
using Labology.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labology.DataAcess.Repository
{
    public class OfficerRepository : Repository<Officer>, IOfficerRepository
    {
        private ApplicationDbContext _db;
        public OfficerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Officer obj)
        {
            _db.Officers.Update(obj);
        }
    }
}
