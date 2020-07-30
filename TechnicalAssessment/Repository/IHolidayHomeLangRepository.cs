using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TechnicalAssessment.Model;

namespace TechnicalAssessment.Repository
{
    public interface IHolidayHomeLangRepository : IGenericRepository<HolidayHomeLang>
    {

        HolidayHomeLang FindByLangAndHolidayHome(int lang, int holidayhome);
    }
}
