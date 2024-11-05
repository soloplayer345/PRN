using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        public static List<Member> Getmembers()
        {
            List<Member> members = new List<Member>();
            try
            {
                using (var context = new SalemanagmentContext())
                {
                    members = context.Members.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return members;
        }

        public static Member Getmembers(int id) 
        {
            Member member;
            try
            {
                using(var context = new SalemanagmentContext())
                {
                    member = context.Members.FirstOrDefault(x => x.Id.Equals(id));
                }
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            return member;
        }

        public static void CreateMembers(Member member) 
        {
            try
            {
                using (var context = new SalemanagmentContext())
                {
                    context.Members.Add(member);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteMembers(Member member)
        {
            try
            {
                using (var context = new SalemanagmentContext())
                {
                    context.Members.Add(member);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void Updatemember(Member member)
        {
            try
            {
                using (var context = new SalemanagmentContext())
                {
                    var a = context.Members.Update(member);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
