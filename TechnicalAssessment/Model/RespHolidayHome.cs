using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalAssessment.Model
{
    public class RespHolidayHome
    {

        public int Id { get; set; }

        public Owner Owner { get; set; }

        public string Alias { get; set; }

        public List<HolidayHomeLang> Langs { get; set; }

        public List<HolidayHomeFreeDay> FreeDay { get; set; }

    }
}
