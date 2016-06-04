using System.Collections.Generic;

namespace DataAccess
{
    public class ProfileInformation
    {
        private readonly List<Profession> _professions;

        public ProfileInformation()
        {
            _professions = new List<Profession>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public string DisplayName { get; set; }

        public List<Profession> Professions
        {
            get { return _professions; }
        }
    }
}
