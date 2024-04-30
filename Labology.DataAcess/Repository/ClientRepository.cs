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
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        private ApplicationDbContext _db;
        public ClientRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Client obj)
        {
            var objFromDb = _db.Clients.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.CName = obj.CName;
                objFromDb.Mobile = obj.Mobile;
                objFromDb.Dist = obj.Dist;
                objFromDb.Pos = obj.Pos;
                objFromDb.Pin = obj.Pin;
                objFromDb.LandMark = obj.LandMark;
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
