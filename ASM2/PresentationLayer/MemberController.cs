using BusinessLayer;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    internal class MemberController
    {
        MemberBusiness memberBusiness = new MemberBusiness();

        public Member Create(Member member)
        {
            return memberBusiness.Create(member);
        }


        public void Update(int id, Member member)
        {
            memberBusiness.Update(id, member);
        }

        public Member Get(int id)
        {
            return memberBusiness.Read(id);
        }

        public void Delete(int id)
        {
            memberBusiness.Delete(id);
        }

        public List<Member> Get()
        {
            return memberBusiness.Read();
        }

        public Member Login(String email, String password) 
        {
            return memberBusiness.Login(email, password);
        }

    }
}
