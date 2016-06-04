using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public enum SkillCategory
    {
        General = 1,
        Design = 2,
        Programming = 3,
        Process = 4,
        Tools = 5
    }

    public class Skill
    {
        public SkillCategory Category { get; set; }

        public int ID { get; set; }

        public string SkillName { get; set; }

        public string Summary { get; set; }

        public string LastUsed { get; set; }

    }
}
