using System.Collections.Generic;
using System.Linq;
using TechnicalAssessment.Model;
using TechnicalAssessment.DBContexts;

namespace TechnicalAssessment.Repository.impl
{
    public class HolidayHomeRepository : IHolidayHomeRepository
    {
        private readonly Context _dbContext;

        public HolidayHomeRepository(Context dbContext) => this._dbContext = dbContext;

        public void Delete(HolidayHome entity)
        {
            HolidayHome holidayHome = _dbContext.HolidayHomes.Find(entity.Id);
            _dbContext.HolidayHomes.Remove(holidayHome);
            Save();
        }

        public HolidayHome Find(HolidayHome entity) => this._dbContext.HolidayHomes.Find(entity);

        public void Delete(int id)
        {
            HolidayHome owner = this._dbContext.HolidayHomes.Find(id);
            this._dbContext.HolidayHomes.Remove(owner);
            Save();
        }

        public IEnumerable<HolidayHome> FindAll() => this._dbContext.HolidayHomes.ToList();

        public HolidayHome FindById(int id) => this._dbContext.HolidayHomes.Find(id);

        public void Insert(HolidayHome entity)
        {
            this._dbContext.Add(entity);
            Save();
        }

        public void Save() => this._dbContext.SaveChanges();

        public void Update(HolidayHome entity)
        {
            this._dbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }

        public IEnumerable<HolidayHome> Find(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
