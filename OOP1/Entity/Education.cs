using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Entity
{
    public class Education : IEntity
    {
        public int EducationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Category Category { get; set; }
    }
}
