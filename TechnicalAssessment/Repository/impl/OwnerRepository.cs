using System.Collections.Generic;
using System.Linq;
using TechnicalAssessment.Model;
using TechnicalAssessment.DBContexts;

namespace TechnicalAssessment.Repository.impl
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly Context _dbContext;

        public OwnerRepository(Context dbContext) => this._dbContext = dbContext;

        public void Delete(Owner entity)
        {
            Owner owner = _dbContext.Owners.Find(entity.Id);
            _dbContext.Owners.Remove(owner);
            Save();
        }

        public Owner Find(Owner entity) => this._dbContext.Owners.Find(entity);

        public void Delete(int id)
        {
            Owner owner = this._dbContext.Owners.Find(id);
            this._dbContext.Owners.Remove(owner);
            Save();
        }

        public IEnumerable<Owner> FindAll() => this._dbContext.Owners.ToList();

        public Owner FindById(int id) => this._dbContext.Owners.Find(id);

        public void Insert(Owner entity)
        {
            this._dbContext.Add(entity);
            Save();
        }

        public void Save() => this._dbContext.SaveChanges();

        public void Update(Owner entity)
        {
            this._dbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }

        public IEnumerable<Owner> Find(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
