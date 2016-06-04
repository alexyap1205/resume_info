using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess;

namespace alexyap1205info.ViewModels.Contact
{
    public class ContactVM
    {
        public ContactVM()
        {
            
        }

        public ContactVM(ContactInformation information)
        {
            this.Address = information.Address;
            this.Mobile = information.Mobile;
        }

        public string Address { get; set; }

        public string Mobile { get; set; }
    }
}