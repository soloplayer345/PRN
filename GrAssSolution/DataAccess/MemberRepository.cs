using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberRepository : IMemberRepository, IDisposable
    {
        private EStoreContext context;
        private bool disposed = false;

        public MemberRepository(EStoreContext context)
        {
            this.context = context;
        }

        public void AddMember(Member member)
        {
            context.Members.Add(member);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Member? GetMember(int id)
        {
            return context.Members.Find(id);
        }

        public IEnumerable<Member> GetMembers()
        {
            return context.Members.ToList();
        }

        public void RemoveMember(Member member)
        {
            context.Members.Remove(member);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateMember(Member member)
        {
            context.Members.Update(member);
        }
    }
}
