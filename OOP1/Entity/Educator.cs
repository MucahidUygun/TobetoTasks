using OOP1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Entity
{
    public class Educator : User,IEntity
    {
        public string InWork { get; set; }
        public string EducationBackground { get; set; }
    }
}
