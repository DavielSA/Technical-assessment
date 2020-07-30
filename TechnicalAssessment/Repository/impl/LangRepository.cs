using System.Collections.Generic;
using System.Linq;
using TechnicalAssessment.Model;
using TechnicalAssessment.DBContexts;

namespace TechnicalAssessment.Repository.impl
{
    public class LangRepository : ILangRepository
    {
        private readonly Context _dbContext;

        public LangRepository(Context dbContext) => this._dbContext = dbContext;

        public void Delete(Lang entity)
        {
            Lang lang = _dbContext.Langs.Find(entity.Id);
            _dbContext.Langs.Remove(lang);
            Save();
        }

        public Lang Find(Lang entity) => this._dbContext.Langs.Find(entity);


        public void Delete(int id)
        {
            Lang lang = this._dbContext.Langs.Find(id);
            this._dbContext.Langs.Remove(lang);
            Save();
        }

        public IEnumerable<Lang> FindAll() => this._dbContext.Langs.ToList();


        public Lang FindById(int id) => this._dbContext.Langs.Find(id);

        public void Insert(Lang entity)
        {
            this._dbContext.Add(entity);
            Save();
        }

        public void Save() => this._dbContext.SaveChanges();

        public void Update(Lang entity)
        {
            this._dbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }

        public IEnumerable<Lang> Find(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
