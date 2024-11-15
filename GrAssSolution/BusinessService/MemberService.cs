using BusinessObject;
using DataAccess;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService
{
    public class MemberService
    {
        private IMemberRepository memberRepository;
        IConfiguration? configuration;

        public MemberService()
        {
            this.memberRepository = new MemberRepository(new BusinessObject.EStoreContext());
        }

        public void CreateMember(Member member)
        {
            memberRepository.AddMember(member);
        }

        public IEnumerable<Member> GetMember() 
        {
            return memberRepository.GetMembers();
        }

        public Member? GetMemberById(int id) 
        {
            return memberRepository.GetMember(id);
        }

        public void UpdateMember(Member member) 
        {
            memberRepository.UpdateMember(member);
        }

        public void DeleteMember(Member member) 
        {
            memberRepository.RemoveMember(member);
        }

        public Member? LoginMember(string email, string password)
        {
            List<Member> members = (List<Member>)memberRepository.GetMembers();
            for (int i = 0; i < members.Count; i++) 
            {
                if (members[i].Email.Equals(email) && members[i].Equals(password))
                {
                    return members[i];
                }
            }
            return null;
        }

        public bool IsAdmin(string email, string password)
        {
            var path = Directory.GetCurrentDirectory();
            this.configuration = new ConfigurationBuilder()
                    .SetBasePath(path)
                    .AddJsonFile("appsetting.json", true, true).Build();
            var adminEmail = configuration["admin-account:email"];
            var pass = configuration["admin-account:password"];
            return adminEmail.Equals(email) && pass.Equals(password);
        }

    }
}
