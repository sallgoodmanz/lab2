using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IStudent : IHuman
    {

        int YearOfStudy { get; set; }

        string StudentTicket { get; set; }

        string GroupName { get; set; }

        bool HasWorkingDevice { get; set; }

    }
}
