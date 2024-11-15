using Microsoft.AspNetCore.Http;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using BusinessService;

namespace eStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly MemberService memberService;

        public MemberController(MemberService memberService) 
        {
            this.memberService = memberService;
        }

        [HttpGet]
        public ActionResult Get() {
            var members = memberService.GetMember();
            return Ok("ok");
        }


        [HttpPost("Login")]
        public ActionResult Login(String email,string password) {
            return Ok(email+password);
        }
    }
}
