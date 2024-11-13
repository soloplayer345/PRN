using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal interface IMemberRepository : IDisposable
    {
        IEnumerable<Member> GetMembers();
        Member GetMember(int id);
        void AddMember(Member member);
        void RemoveMember(Member member);
        void UpdateMember(Member member);
        void Save();
    }
}
