using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TeacherUniversity.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
