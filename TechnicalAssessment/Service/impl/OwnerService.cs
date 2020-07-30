using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TechnicalAssessment.Repository;
using TechnicalAssessment.Model;
using System.Transactions;

namespace TechnicalAssessment.Service
{
    public class OwnerService : IOwnerService
    {

        private readonly IOwnerRepository _repository;
        public OwnerService(IOwnerRepository repo) => this._repository = repo;

        public bool Delete(int id) {
            this._repository.Delete(id);
            Owner exist = this._repository.FindById(id);
            return exist == null
                ? true
                : false;
        }

        public List<Owner> Get() => this._repository.FindAll().ToList<Owner>();

        public Owner Get(int id) => this._repository.FindById(id);

        public Owner Save(Owner entity)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                this._repository.Insert(entity);
                scope.Complete();
                return this._repository.Find(entity);
            }
        }

        public Owner Update(int id, Owner entity)
        {
            if (entity != null)
            {
                using (var scope = new TransactionScope())
                {
                    this._repository.Update(entity);
                    scope.Complete();
                    return this._repository.Find(entity);
                }
            }
            return null;
        }
    }
}
