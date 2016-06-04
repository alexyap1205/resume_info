using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Profession
    {
        private Dictionary<SkillCategory, List<Skill>> _skills;

        public Profession()
        {
            _skills = new Dictionary<SkillCategory, List<Skill>>();
        }

        public int ID { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public Dictionary<SkillCategory, List<Skill>> Skills
        {
            get { return _skills; }
        }
    }
}
