using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IHuman
    {
        string Name { get; set; }
        string Surname { get; set; }
        string PassportID { get; set; }
    }
}
