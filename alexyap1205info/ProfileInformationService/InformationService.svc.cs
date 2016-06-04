using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;
using DataAccess;

namespace ProfileInformationService
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "InformationService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select InformationService.svc or InformationService.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class InformationService : IInformationService
    {
        public List<Education> GetEducations()
        {
            IDataAccessor accessor = new DataAccessor();
            accessor.Initialize();

            List<EducationDetail> educationDetails = accessor.GetEducations(5);

            accessor.UnInitialize();

            List<Education> educations = new List<Education>();

            foreach (EducationDetail detail in educationDetails)
            {
                Education education = new Education()
                {
                    ID = detail.ID,
                    Institution = detail.Institution,
                    Summary = detail.Summary,
                    Title = detail.Title,
                    YearCompleted = detail.YearCompleted
                };

                educations.Add(education);
            }

            return educations;
        }
    }
}
