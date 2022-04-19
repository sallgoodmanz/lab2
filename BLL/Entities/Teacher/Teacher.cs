using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Teacher : Human, ITeacher
    {
        public bool HasWorkingDevice { get; set; }
        public Teacher() { }
        public Teacher(string name, string surname, string PassportID, int age, bool hasWorkingDevice)
            : base(name, surname, PassportID, age)
        { HasWorkingDevice = hasWorkingDevice; }
    }
}
