using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProfileInformationService
{
    [DataContract]
    public class Education
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Institution { get; set; }

        [DataMember]
        public string Summary { get; set; }

        [DataMember]
        public int YearCompleted { get; set; }
    }

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IInformationService
    {

        [OperationContract]
        List<Education> GetEducations();

    }
}
