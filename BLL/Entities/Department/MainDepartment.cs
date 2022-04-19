using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MainDepartment
    {
        private IGroupsDatabase groupsDB;
        private Group group;
        private List<ITeacher> teachersList;
        public MainDepartment(IGroupsDatabase database)
        {
            groupsDB = database;
            teachersList = new List<ITeacher>();
        }

        public Group CreateGroup(string name)
        {
            group = new Group(name);
            groupsDB.MoveToDatabase(group);
            return group;
        }

        public void AddTeacherToTheDeparment(Teacher teacher)
        {
            teachersList.Add(teacher);
        }
        public bool AddStudentToTheGroup(string groupName, Student student)
        {
            foreach (var group in groupsDB.getListOfGroups())
            {
                if (group.Name == groupName)
                {
                    group.AddStudentToTheGroup(student);
                    return true;
                }
            }
            return false;
        }
        public bool DeleteStudentFromTheGroup(string groupName, Student student)
        {
            foreach (var group in groupsDB.getListOfGroups())
            {
                if (group.Name == groupName)
                {
                    group.RemoveStudent(student);
                    return true;
                }
            }
            return false;
        }
        public bool TransferStudentToAnotherGroup(string oldGroupName, Group newGroup, Student student)
        {
            foreach (var group in groupsDB.getListOfGroups())
            {
                if (group.Name == oldGroupName)
                {
                    group.TransferToAnotherGroup(newGroup, student);
                    return true;
                }
            }
            return false;
        }

        public void Update()
        {
            foreach (var group in groupsDB.getListOfGroups())
            {
                if (group.GetStudentsCount() >= 10 && teachersList.Count != 0)
                {
                    group.StartCourse();
                }
            }
        }
    }
}
