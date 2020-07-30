using System.Collections.Generic;
using System.Linq;
using TechnicalAssessment.Model;
using TechnicalAssessment.DBContexts;

namespace TechnicalAssessment.Repository.impl
{
    public class HolidayHomeFreeDayRepository : IHolidayHomeFreeDayInterface
    {

        private readonly Context _dbContext;

        public HolidayHomeFreeDayRepository(Context dbContext) => this._dbContext = dbContext;

        public void Delete(HolidayHomeFreeDay entity)
        {
            HolidayHomeFreeDay holidayHomeFreeDay = _dbContext.HolidayHomeFreeDays.Find(entity);
            _dbContext.HolidayHomeFreeDays.Remove(holidayHomeFreeDay);
            Save();
        }

        public void Delete(int id)
        {
            HolidayHomeFreeDay holidayHomeFreeDay = _dbContext.HolidayHomeFreeDays.Find(id);
            _dbContext.HolidayHomeFreeDays.Remove(holidayHomeFreeDay);
            Save();
        }

        public HolidayHomeFreeDay Find(HolidayHomeFreeDay entity) => this._dbContext.HolidayHomeFreeDays.Find(entity);

        public IEnumerable<HolidayHomeFreeDay> FindAll() => this._dbContext.HolidayHomeFreeDays.ToList();

        public HolidayHomeFreeDay FindByHolidayHome(int holidayhome) =>
            (
                from c
                in this._dbContext.HolidayHomeFreeDays
                where c.HolidayHomeId.Equals(holidayhome)
                select c
            ).FirstOrDefault<HolidayHomeFreeDay>();

        public HolidayHomeFreeDay FindById(int id) =>
            (
                from c
                in this._dbContext.HolidayHomeFreeDays
                where c.HolidayHomeId.Equals(id)
                select c
            ).FirstOrDefault<HolidayHomeFreeDay>();

        public void Insert(HolidayHomeFreeDay entity)
        {
            this._dbContext.Add(entity);
            Save();
        }

        public void Save() => this._dbContext.SaveChanges();

        public void Update(HolidayHomeFreeDay entity)
        {
            this._dbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }


        public IEnumerable<HolidayHomeFreeDay> Find(int id) => (
           from c
           in this._dbContext.HolidayHomeFreeDays
           where c.HolidayHomeId.Equals(id)
           select c
       );


    }
}
