using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oldest_Family_Member
{
    public class Family
    {
        private readonly HashSet<Person> members;

        public Family()
        {
            this.members = new HashSet<Person>();
        }

        public void AddMembers(Person member)
        {
            members.Add(member);
        }

        public Person GetOldestMember() => members.OrderByDescending(p => p.Age).FirstOrDefault();
    }
}
