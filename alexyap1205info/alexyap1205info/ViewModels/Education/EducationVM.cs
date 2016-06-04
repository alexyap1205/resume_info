using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace alexyap1205info.ViewModels.Education
{
    public class EducationVM
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Institution { get; set; }

        public string Summary { get; set; }

        public int YearCompleted { get; set; }
    }
}