using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService1.DataContracts;

namespace WcfService1.ServiceContracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<CustomerDetails> GetCustomerDetails(string CustomerName);

        //[OperationContract]
        //List<CustomerDetails> INSERTDB(string CustomerName);

        [OperationContract]
        string InsertCustomerDetails(CustomerDetails customerInfo);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    
}
