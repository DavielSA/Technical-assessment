using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalAssessment.Model
{
    public class HolidayHomeLang
    {
        public int HolidayHomeId { get; set; }

        public int LangId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Create { get; set; }

        public DateTime LastUpdate { get; set; }


    }
}
