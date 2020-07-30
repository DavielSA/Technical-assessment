using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalAssessment.Repository
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> FindAll();

        T FindById(int id);

        T Find(T entity);

        IEnumerable<T> Find(int id);

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);
        void Delete(int id);

        void Save();
    }
}
