using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IGroupsDatabase
    {
        int Count { get; }
        bool MoveToDatabase(IGroup group);
        bool RemoveFromDatabase(IGroup group);
        List<IGroup> getListOfGroups();
        IGroup SearchForGroup(string name);
    }
}
