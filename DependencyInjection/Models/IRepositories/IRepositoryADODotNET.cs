using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models.IRepositories
{
   public interface IRepositoryADODotNET<T>
    {
        DataTable GetAll();
        T Get();
        int Update(T obj);
        int Delete(int Id);
    }
}
