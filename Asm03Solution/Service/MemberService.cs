using DataAccess;


namespace MemberService
{
    public class MemberService
    {

        public void CreateMember(Member member)
        {
            MemberDAO.CreateMembers(member);
        }

        public List<Member> GetMembers()
        {
            return MemberDAO.Getmembers();
        }

        public Member GetMember(int id)
        {
            return MemberDAO.Getmembers(id);
        }

        public void UpdateMember(Member member)
        {
            MemberDAO.CreateMembers(member);
        }


        public void DeleteMember(Member member)
        {
            MemberDAO.DeleteMembers(member);
        }

        public Member MemberLogin(string email, string password)
        {
            return MemberDAO.Getmembers().FirstOrDefault(x => x.Email.Equals(email) && x.Password.Equals(password));
        }

    }
}
