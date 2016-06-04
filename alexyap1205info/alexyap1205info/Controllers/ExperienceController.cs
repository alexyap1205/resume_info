using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using alexyap1205info.ViewModels.Experience;
using DataAccess;

namespace alexyap1205info.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        public ActionResult Index()
        {
            IDataAccessor accessor = new DataAccessor();
            accessor.Initialize();

            List<ExperienceDetail> experiences = accessor.GetExperiences(5);

            accessor.UnInitialize();

            List<ExpereinceVM> vms = new List<ExpereinceVM>();
            foreach (ExperienceDetail detail in experiences)
            {
                ExpereinceVM vm = new ExpereinceVM()
                {
                    ID = detail.ID,
                    CompanyName = detail.CompanyName
                };

                vms.Add(vm);
            }

            return View(vms);
        }
    }
}