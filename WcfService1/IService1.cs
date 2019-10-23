using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<CustomerDetails> GetCustomerDetails(string CustomerName , string userPassword);

        //[OperationContract]
        //List<CustomerDetails> INSERTDB(string CustomerName);

        [OperationContract]
        string InsertCustomerDetails(CustomerDetails customerInfo);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CustomerDetails
    {
        string estarappid = string.Empty;
        string taskid = string.Empty;
        string customername = string.Empty;
        string fieldnote = string.Empty;
        string producttype = string.Empty;
        string branchname = string.Empty;
        string dtmstartsend = string.Empty;
        string dtmendsend = string.Empty;
        string dtmapproved = string.Empty;
        string surveyorname = string.Empty;

        [DataMember]
        public string ESTAR_APPID
        {
            get { return estarappid; }
            set { estarappid = value; }
        }
        [DataMember]
        public string TASK_ID
        {
            get { return taskid; }
            set { taskid = value; }
        }

        [DataMember]
        public string CUSTOMER_NAME
        {
            get { return customername; }
            set { customername = value; }
        }

        [DataMember]
        public string FIELD_NOTE
        {
            get { return fieldnote; }
            set { fieldnote = value; }
        }

        [DataMember]
        public string PRODUCT_TYPE
        {
            get { return producttype; }
            set { producttype = value; }
        }

        [DataMember]
        public string BRANCH_NAME
        {
            get { return branchname; }
            set { branchname = value; }
        }

        [DataMember]
        public string DTM_START_SEND
        {
            get { return dtmstartsend; }
            set { dtmstartsend = value; }
        }

        [DataMember]
        public string DTM_END_SEND
        {
            get { return dtmendsend; }
            set { dtmendsend = value; }
        }

        [DataMember]
        public string DTM_APPROVED
        {
            get { return dtmapproved; }
            set { dtmapproved = value; }
        }
        [DataMember]
        public string SURVEYOR_NAME
        {
            get { return surveyorname; }
            set { surveyorname = value; }
        }
    }
}
