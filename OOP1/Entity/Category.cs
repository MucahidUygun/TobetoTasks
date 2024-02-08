using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Entity
{
    public class Category :IEntity
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public List<Education> Educations { get; set; }
    }
}
