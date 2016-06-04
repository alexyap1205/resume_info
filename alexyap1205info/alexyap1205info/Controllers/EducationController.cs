using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using alexyap1205info.InformationServices;
using alexyap1205info.ViewModels.Education;
using DataAccess;

namespace alexyap1205info.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        public ActionResult Index()
        {
            //IDataAccessor accessor = new DataAccessor();
            //accessor.Initialize();

            //List<EducationDetail> educations = accessor.GetEducations(5);

            //accessor.UnInitialize();

            List<EducationVM> vms = new List<EducationVM>();

            //foreach (EducationDetail detail in educations)
            //{
            //    EducationVM vm = new EducationVM()
            //    {
            //        ID = detail.ID,
            //        Institution = detail.Institution,
            //        Summary = detail.Summary,
            //        Title = detail.Title,
            //        YearCompleted = detail.YearCompleted
            //    };

            //    vms.Add(vm);
            //}

            return View(vms);
        }

        public ActionResult GetEducations()
        {
            IInformationService service = new InformationServiceClient();
            Education[] educations = service.GetEducations();

            JsonResult result = Json(educations, "application/json", JsonRequestBehavior.AllowGet);

            return result;
        }
    }
}