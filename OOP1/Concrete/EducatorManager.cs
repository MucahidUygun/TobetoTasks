using OOP1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Concrete
{
    public class EducatorManager : IEducatorServices
    {
        public string GetEducationBackground()
        {
            return "Boğaziçi Üniversitesi,Galatasaray Lisesi";
        }

        public string GetEducatorInWork()
        {
            return "Apple";
        }

        public string GetUserBirthDate()
        {
            return "04-01-1985";
        }

        public string GetUserName()
        {
            return "John Doe";
        }
    }
}
