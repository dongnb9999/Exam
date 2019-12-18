using System.Linq;
using System.Web.Mvc;
using StudentServiceClient = Exam_Client.ServiceReference1.StudentServiceClient;

namespace Exam_EAP_Client.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Exam_Client.ServiceReference1.StudentServiceClient client = new StudentServiceClient();
            var student = client.GetStudentList().ToList();
            return View(student);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}