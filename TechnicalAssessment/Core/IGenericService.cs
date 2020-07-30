using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalAssessment.Service
{
    public interface IGenericService<T>
    {
        

        List<T> Get();

        T Get(int id);

        T Save(T entity);


        T Update(int id, T entity);


        bool Delete(int id);
        
    }
}
