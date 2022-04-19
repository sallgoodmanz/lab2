using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Group : IGroup
    {
        #region data
        private string name;
        private const int MAX_CAPACITY_OF_A_GROUP = 30;
        public List<IStudent> studentGroup;
        public List<string> learningDisciplines;
        #endregion

        #region properties
        public string Name
        {
            get { return name; }
            set
            {
                if (MyRegEx.GroupName.IsMatch(value))
                {
                    name = value;
                }
                else throw new MyRegException("GroupName");
            }
        }
        public bool isReadyToStart { get; set; }
        #endregion

        public Group() { }
        public Group(string groupName)
        {
            Name = groupName;
            studentGroup = new List<IStudent>(MAX_CAPACITY_OF_A_GROUP);
            learningDisciplines = new List<string>(10);
            isReadyToStart = false;
        }

        public int GetStudentsCount()
        {
            return studentGroup.Count;
        }
        public void AddStudentToTheGroup(IStudent student)
        {
            if (studentGroup.Count == MAX_CAPACITY_OF_A_GROUP) { throw new Exception("Група заповнена! Створіть нову або звільніть місце."); }
            studentGroup.Add(student);
            student.GroupName = this.Name;
        }
        public void RemoveStudent(IStudent student)
        {
            studentGroup.Remove(student);
            student.GroupName = "Без групи";
        }
        public void TransferToAnotherGroup(Group newGroup, IStudent student)
        {
            newGroup.AddStudentToTheGroup(student);
            studentGroup.Remove(student);
            student.GroupName = newGroup.Name;
        }

        public void ChooseSubject(string subject)
        {
            if (this.isReadyToStart)
            {
                foreach (var item in learningDisciplines)
                {
                    if (item == subject) { throw new Exception("Дана дисципліна вже вивчається!"); }

                }
                learningDisciplines.Add(subject);
            }
        }
        public void StartCourse()
        {
            isReadyToStart = true;
        }
    }
}
