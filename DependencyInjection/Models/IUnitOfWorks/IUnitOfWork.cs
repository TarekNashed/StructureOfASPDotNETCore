using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models.IUnitOfWorks
{
    public interface IUnitOfWork
    {
        int SaveChanges();
    }
}
