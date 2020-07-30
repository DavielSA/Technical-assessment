using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalAssessment.Model
{
    public class Owner
    {
        private int _rating;

        public int Id { get; set; }

        public string Name { get; set; }

        public int Rating {
            get {
                return this._rating;
            }
            set {
                this._rating = value < 0 || value > 9 ? 0 : value;
            }
        }

    }
}
