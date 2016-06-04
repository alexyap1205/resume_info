using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess;

namespace alexyap1205info.ViewModels.Home
{
    public class SkillInfoVM
    {
        public SkillInfoVM(Skill skill)
        {
            this.Name = skill.SkillName;
            this.Summary = skill.Summary;
            if (!String.IsNullOrEmpty(skill.LastUsed))
            {
                this.Summary += String.Format("\r\nLast Used: {0}", skill.LastUsed);
            }
        }

        public string Name { get; set; }

        public string Summary { get; set; }
    }
}