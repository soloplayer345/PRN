﻿using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MemberBusiness
    {
        private readonly MemberRepository memberRepository;

        public Member Create(Member member)
        {
            return memberRepository.Create(member);
        }

        public List<Member> Read()
        {
            return memberRepository.GetAllMembers();
        }

        public Member Read(int id)
        {
            return memberRepository.GetMember(id);
        }

        public void Update(int id, Member member)
        {
            memberRepository.Update(id, member);
        }

        public void Delete(int id)
        {
            memberRepository.Delete(id);
        }
        
        public Member Login(string email, string password)
        {
            return memberRepository.Login(email, password);
        }
    }
}