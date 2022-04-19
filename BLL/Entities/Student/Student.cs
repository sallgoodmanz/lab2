using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Student : Human, IStudent
    {
        #region data
        private int yearOfStudy;
        private string studentTicket;
        private string groupName;
        #endregion
        #region properties
        public int YearOfStudy
        {
            get { return yearOfStudy; }
            set
            {
                if (MyRegEx.YearOfStudy.IsMatch(value.ToString()))
                {
                    yearOfStudy = value;
                }
                else throw new MyRegException("YearOfStudy");
            }
        }
        public string StudentTicket
        {
            get { return studentTicket; }
            set
            {
                if (MyRegEx.StudentTicket.IsMatch(value))
                {
                    studentTicket = value;
                }
                else throw new MyRegException("StudentTicket");
            }
        }
        public string GroupName
        {
            get { return groupName; }
            set
            {
                groupName = value;
            }
        }
        public bool HasWorkingDevice { get; set; }
        #endregion
        public Student() { }
        public Student(string name, string surname, string PassportID, int age, int yearOfStudy, string studentTicket, bool hasWorkingDevice)
            : base(name, surname, PassportID, age)
        {
            YearOfStudy = yearOfStudy;
            StudentTicket = studentTicket;
            GroupName = "Без групи";
            HasWorkingDevice = hasWorkingDevice;
        }

    }
}
