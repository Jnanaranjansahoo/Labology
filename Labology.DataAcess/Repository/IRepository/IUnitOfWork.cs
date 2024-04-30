using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labology.DataAcess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IOfficerRepository Officer { get; }
        IClientRepository Client { get; }
        void Save();
    }
}
