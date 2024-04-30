using Labology.DataAcess.Data;
using Labology.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labology.DataAcess.Repository.IRepository
{
    public interface IOfficerRepository : IRepository<Officer>
    {
        
        void Update(Officer obj);

    }
}
