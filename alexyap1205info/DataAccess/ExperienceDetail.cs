using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ExperienceDetail
    {
        public int ID { get; set; }

        public string CompanyName { get; set; }

        public string FinalJobTitle { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public string Summary { get; set; }
    }
}
