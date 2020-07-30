using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TechnicalAssessment.Repository;
using TechnicalAssessment.Model;
using System.Transactions;

namespace TechnicalAssessment.Service.impl
{
    public class LangService : ILangService
    {

        private readonly ILangRepository _langRepository;
        public LangService(ILangRepository langRepository) => this._langRepository = langRepository;

        public List<Lang> Get() => this._langRepository.FindAll().ToList<Lang>();

        public Lang Get(int id) => this._langRepository.FindById(id);

        public Lang Save(Lang entity)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                this._langRepository.Insert(entity);
                scope.Complete();
                return this._langRepository.Find(entity);
            }
        }

        public Lang Update(int id, Lang entity)
        {
            if (entity != null)
            {
                using (var scope = new TransactionScope())
                {
                    this._langRepository.Update(entity);
                    scope.Complete();
                    return this._langRepository.Find(entity);
                }
            }
            return null;
        }

        public bool Delete(int id)
        {
            this._langRepository.Delete(id);
            Lang exist = this._langRepository.FindById(id);
            return exist == null 
                ? true 
                : false;
        }
    }
}

