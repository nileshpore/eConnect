using eConnect.DataAccess.Contract;
using eConnect.DataAccess.Implementation;
using System.Web.Mvc;
using System.Web.Security;

namespace eConnect.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserRepository userRepository;
        public LoginController()
        {
            userRepository = new UserRepository();
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Validate(string username, string password)
        {
            var isAuthenticated = userRepository.ValidateUser(username, password);
            if (isAuthenticated)
            {
                FormsAuthentication.SetAuthCookie(username, false);
            }
            return Json(isAuthenticated, JsonRequestBehavior.AllowGet);
        }
    }
}