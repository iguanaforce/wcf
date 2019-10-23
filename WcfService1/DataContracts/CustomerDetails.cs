using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.DataContracts
{
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