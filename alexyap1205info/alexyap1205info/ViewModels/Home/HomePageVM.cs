using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alexyap1205info.ViewModels.Home
{
    public class HomePageVM
    {
        private List<SkillInfoVM> _generalSkills;
        private List<SkillInfoVM> _technicalSkills;
        private List<SkillInfoVM> _otherSkills;

        public HomePageVM()
        {
            _generalSkills = new List<SkillInfoVM>();
            _technicalSkills = new List<SkillInfoVM>();
            _otherSkills = new List<SkillInfoVM>();
        }

        public string DisplayName { get; set; }

        public string ProfileSummary { get; set; }

        public List<SkillInfoVM> GeneralSkills
        {
            get { return _generalSkills; }
        }

        public List<SkillInfoVM> TechnicalSkills
        {
            get { return _technicalSkills; }
        }

        public List<SkillInfoVM> OtherSkills
        {
            get { return _otherSkills; }
        }
    }
}
