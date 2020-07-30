using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalAssessment.Model
{
    public class Lang
    {
        private string _code;

        public int Id { get; set; }

        public string Code {
            get { return this._code; }
            set {
                this._code = !string.IsNullOrEmpty(value) && value.Length > 2 ? value.Substring(0, 2) : value;
            }
        }

        public string Flag { get; set; }

        public string Name { get; set; }
    }
}
