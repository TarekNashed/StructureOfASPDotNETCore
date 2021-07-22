using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models.IRepositories
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> GetAll();
        T get(int id);
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}
