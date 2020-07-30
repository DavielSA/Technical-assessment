using System.Collections.Generic;
using System.Linq;
using TechnicalAssessment.Model;
using TechnicalAssessment.DBContexts;

namespace TechnicalAssessment.Repository.impl
{
    public class HolidayHomeLangRepository : IHolidayHomeLangRepository
    {

        private readonly Context _dbContext;

        public HolidayHomeLangRepository(Context dbContext) => this._dbContext = dbContext;

        public void Delete(HolidayHomeLang entity)
        {
            HolidayHomeLang holidayHomeLangs = _dbContext.HolidayHomeLangs.Find(entity);
            _dbContext.HolidayHomeLangs.Remove(holidayHomeLangs);
            Save();
        }

        public void Delete(int id)
        {
            HolidayHomeLang holidayHomeLangs = _dbContext.HolidayHomeLangs.Find(id);
            _dbContext.HolidayHomeLangs.Remove(holidayHomeLangs);
            Save();
        }

        public IEnumerable<HolidayHomeLang> FindAll() => this._dbContext.HolidayHomeLangs.ToList();

        public HolidayHomeLang FindById(int id) => this._dbContext.HolidayHomeLangs.Find(id);

        public void Insert(HolidayHomeLang entity)
        {
            this._dbContext.Add(entity);
            Save();
        }

        public void Save() => this._dbContext.SaveChanges();

        public void Update(HolidayHomeLang entity)
        {
            this._dbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }

        public HolidayHomeLang FindByLangAndHolidayHome(int lang, int holidayhome) =>
            (
                from hhl
                in _dbContext.HolidayHomeLangs
                where hhl.LangId.Equals(lang) && hhl.HolidayHomeId.Equals(holidayhome)
                select hhl
            ).FirstOrDefault<HolidayHomeLang>();

        public HolidayHomeLang Find(HolidayHomeLang entity) => this._dbContext.HolidayHomeLangs.Find(entity);

        public IEnumerable<HolidayHomeLang> Find(int id) => (
            from c 
            in this._dbContext.HolidayHomeLangs
            where c.HolidayHomeId.Equals(id)
            select c
        );
    }
}
