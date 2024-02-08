using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Interface
{
    public interface IStutendServices : IUserServices
    {
        double GetStutendAverage();

        bool GetStutendIsWorking();
    }
}
