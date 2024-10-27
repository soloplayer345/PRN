using BusinessLayer;

using RepositoryLayer;

namespace PresentationLayer
{
    internal class MemberController
    {
        private readonly MemberBusinesslayer memberBusinesslayer;

        public Member Create(Member member)
        {
            return memberBusinesslayer.Create(member);
        }


        public void Update(int id,Member member)
        {
            memberBusinesslayer.Update(id,member);
        }

        public Member Get(int id)
        {
            return memberBusinesslayer.Read(id);
        }

        public void Delete(int id)
        {
            memberBusinesslayer.Delete(id);
        }

        public List<Member> Get() 
        {
            return memberBusinesslayer.Read();
        }

    }
}
