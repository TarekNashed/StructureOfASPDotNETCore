using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models.IUnitOfWorks;

namespace DependencyInjection.Models.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationDBContext applicationDBContext { get; set; }
        public UnitOfWork(ApplicationDBContext applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }
        public int SaveChanges()
        {
            return applicationDBContext.SaveChanges();
        }
    }
}
