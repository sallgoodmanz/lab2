using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GroupsDatabase : IGroupsDatabase
    {
        private List<IGroup> groups;
        public int Count { get { return groups.Count; } }

        public GroupsDatabase()
        {
            groups = new List<IGroup>();
        }

        public List<IGroup> getListOfGroups()
        {
            return new List<IGroup>(groups);
        }

        public bool MoveToDatabase(IGroup group)
        {
            groups.Add(group);
            return true;
        }

        public bool RemoveFromDatabase(IGroup group)
        {
            return groups.Remove(group);
        }

        public IGroup SearchForGroup(string name)
        {
            foreach (var group in getListOfGroups())
            { if (group.Name == name) { return group; } }
            return null;
        }
    }
}
