using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.WebSockets;
using alexyap1205info.ViewModels.Home;
using DataAccess;

namespace alexyap1205info.Controllers
{
    public class SkillsController : ApiController
    {
        [HttpGet]
        [ActionName("Overview")]
        public HomePageVM Overview()
        {
            IDataAccessor accessor = new DataAccessor();
            accessor.Initialize();
            ProfileInformation information = accessor.GetDefaultProfile();
            Profession defaultProfession = accessor.GetDefaultProfession(information);
            Dictionary<SkillCategory, List<Skill>> skillsDictionary = accessor.GetSkills(defaultProfession);
            accessor.UnInitialize();

            HomePageVM vm = new HomePageVM()
            {
                DisplayName = information.DisplayName,
                ProfileSummary = defaultProfession.Summary
            };


            GetSkills(skillsDictionary, vm.GeneralSkills, SkillCategory.General);
            GetSkills(skillsDictionary, vm.TechnicalSkills, SkillCategory.Design);
            GetSkills(skillsDictionary, vm.TechnicalSkills, SkillCategory.Programming);
            GetSkills(skillsDictionary, vm.OtherSkills, SkillCategory.Process);
            GetSkills(skillsDictionary, vm.OtherSkills, SkillCategory.Tools);

            return vm;
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

    }
}
