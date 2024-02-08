using OOP1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Entity
{
    public class Stutend : User,IEntity
    {
        public double Average { get; set; }
        public bool IsWorking { get; set; }
        public string HignSchool { get; set; }
        public string University { get; set; }
    }
}
