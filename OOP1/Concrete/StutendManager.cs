using OOP1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Concrete
{
    public class StutendManager : IStutendServices
    {
        
        public double GetStutendAverage()
        {
            return 2.46;
        }
        
        public bool GetStutendIsWorking()
        {
            return false;
        }

        public string GetUserBirthDate()
        {
            return "24-10-1998";
        }

        public string GetUserName()
        {
            return "Mücahid Uygun";
        }
    }
}
