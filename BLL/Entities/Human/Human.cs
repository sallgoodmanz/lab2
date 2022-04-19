using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Human : IHuman
    {
        #region data
        private string name;
        private string surname;
        private string id;
        private int age;
        #endregion
        #region properties
        public string Name
        {
            get { return name; }
            set
            {
                if (MyRegEx.Name.IsMatch(value))
                {
                    name = value;
                }
                else throw new MyRegException("Name");
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (MyRegEx.Surname.IsMatch(value))
                {
                    surname = value;
                }
                else throw new MyRegException("Surname");
            }
        }
        public string PassportID
        {
            get { return id; }
            set
            {
                if (MyRegEx.PassportID.IsMatch(value))
                {
                    id = value;
                }
                else throw new MyRegException("PassportID");
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (MyRegEx.Age.IsMatch(value.ToString()))
                {
                    age = value;
                }
                else throw new MyRegException("Age");
            }
        }
        #endregion

        public Human() { }
        public Human(string name, string surname, string PassportID, int age)
        {
            Name = name;
            Surname = surname;
            this.PassportID = PassportID;
            Age = age;
        }
    }
}
