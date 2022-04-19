using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IGroup
    {
        string Name { get; set; }

        void AddStudentToTheGroup(IStudent student);
        int GetStudentsCount();
        void RemoveStudent(IStudent student);
        void TransferToAnotherGroup(Group newGroup, IStudent student);
        void StartCourse();
        bool isReadyToStart { get; set; }

    }
}
