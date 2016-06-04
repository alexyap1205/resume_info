using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using alexyap1205info.ViewModels.Experience;
using DataAccess;
using Microsoft.AspNet.SignalR;

namespace alexyap1205info.Hubs
{
    public class ExperienceHub : Hub
    {
        public override Task OnConnected()
        {
            
            return base.OnConnected();
        }

        public void GetDetail(int id)
        {
            IDataAccessor accessor = new DataAccessor();
            accessor.Initialize();

            ExperienceDetail experience = accessor.GetExpericenDetail(id);

            accessor.UnInitialize();

            ExpereinceVM vm = null;

            if (experience != null)
            {
                vm = new ExpereinceVM()
                {
                    ID = experience.ID,
                    CompanyName = experience.CompanyName,
                    Duration = string.Format("{0}/{1} to {2}/{3}", experience.DateFrom.Month, experience.DateFrom.Year, experience.DateTo.Month, experience.DateTo.Year),
                    Title = experience.FinalJobTitle,
                    Summary = experience.Summary
                };
            }

            Clients.Caller.updateDetail(vm.ID, vm);
        }
    }
}