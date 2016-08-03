using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using alexyap1205info.ViewModels.Contact;
using alexyap1205info.ViewModels.Home;
using DataAccess;

namespace alexyap1205info.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //IDataAccessor accessor = new DataAccessor();
            //accessor.Initialize();
            //ProfileInformation information = accessor.GetDefaultProfile();
            //Profession defaultProfession = accessor.GetDefaultProfession(information);
            //Dictionary<SkillCategory, List<Skill>> skillsDictionary = accessor.GetSkills(defaultProfession);
            //accessor.UnInitialize();
            //HomePageVM vm = new HomePageVM()
            //{
            //    DisplayName = information.DisplayName,
            //    ProfileSummary = defaultProfession.Summary
            //};

            //GetSkills(skillsDictionary, vm.GeneralSkills, SkillCategory.General);
            //GetSkills(skillsDictionary, vm.TechnicalSkills, SkillCategory.Design);
            //GetSkills(skillsDictionary, vm.TechnicalSkills, SkillCategory.Programming);
            //GetSkills(skillsDictionary, vm.OtherSkills, SkillCategory.Process);
            //GetSkills(skillsDictionary, vm.OtherSkills, SkillCategory.Tools);

            return View();
        }

        private static void GetSkills(Dictionary<SkillCategory, List<Skill>> skillsDictionary, List<SkillInfoVM> skillsList, SkillCategory category)
        {
            List<Skill> tempSkillsList = null;

            if (skillsDictionary.TryGetValue(category, out tempSkillsList))
            {
                foreach (Skill skill in tempSkillsList)
                {
                    SkillInfoVM skillInfo = new SkillInfoVM(skill);
                    skillsList.Add(skillInfo);
                }
            }
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Looking forward for your call";

            IDataAccessor accessor = new DataAccessor();
            accessor.Initialize();
            ContactInformation information = accessor.GetContactInformation();
            accessor.UnInitialize();

            ContactVM vm = new ContactVM(information);

            return View(vm);
        }
    }
}