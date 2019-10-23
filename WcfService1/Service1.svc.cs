using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<CustomerDetails> GetCustomerDetails(string CustomerName)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RR1T07O\\SQLEXPRESS;Initial Catalog=ADO-MTF;User ID=sa;Password=123456");
            List<CustomerDetails> CustomerDetails = new List<CustomerDetails>();
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select ESTAR_APPID, TASK_ID, CUSTOMER_NAME, FIELD_NOTE, PRODUCT_TYPE, BRANCH_NAME, DTM_START_SEND, DTM_END_SEND, DTM_APPROVED, SURVEYOR_NAME  from STATUS_PROGRESS2 where CUSTOMER_NAME = 'DODI HARTOMI' ", con);
                //cmd.Parameters.AddWithValue("@TASK_ID", CustomerName);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        CustomerDetails customerInfo = new CustomerDetails();
                        customerInfo.ESTAR_APPID = dt.Rows[i]["ESTAR_APPID"].ToString();
                        customerInfo.TASK_ID = dt.Rows[i]["TASK_ID"].ToString();
                        customerInfo.CUSTOMER_NAME = dt.Rows[i]["CUSTOMER_NAME"].ToString();
                        customerInfo.FIELD_NOTE = dt.Rows[i]["FIELD_NOTE"].ToString();
                        customerInfo.PRODUCT_TYPE = dt.Rows[i]["PRODUCT_TYPE"].ToString();
                        customerInfo.BRANCH_NAME = dt.Rows[i]["BRANCH_NAME"].ToString();
                        customerInfo.DTM_START_SEND = dt.Rows[i]["DTM_START_SEND"].ToString();
                        customerInfo.DTM_END_SEND = dt.Rows[i]["DTM_END_SEND"].ToString();
                        customerInfo.DTM_APPROVED = dt.Rows[i]["DTM_APPROVED"].ToString();
                        customerInfo.SURVEYOR_NAME = dt.Rows[i]["SURVEYOR_NAME"].ToString();
                        CustomerDetails.Add(customerInfo);
                    }
                }
                con.Close();
            }
            return CustomerDetails;
        }

        //public List<CustomerDetails> INSERTDB(string CustomerName)
        //{
        //    SqlConnection con = new SqlConnection("Data Source=DESKTOP-RR1T07O\\SQLEXPRESS;Initial Catalog=ADO-MTF;User ID=sa;Password=123456");
        //    List<CustomerDetails> CustomerDetails = new List<CustomerDetails>();
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("insert into STATUS_PROGRESS(ESTAR_APPID, TASK_ID, CUSTOMER_NAME, FIELD_NOTE, PRODUCT_TYPE, BRANCH_NAME, DTM_START_SEND, DTM_END_SEND, DTM_APPROVED, SURVEYOR_NAME) values('bbbb', 'SVY1712220000001', 'DODI HARTOMI1', '- Data valid - Menggunakan aplikasi mobile survey lama - Terlampir 2 usaha (warung nasi dan kelontong) - Tidak ada sales coordinator, spv langsung', 'REGULER NEW', 'BANDA ACEH - MOBIL', '12/22/2017 08.29.12', '12/22/2017 08.28.37', '12/22/2017 08.35.03', '')", con);
        //        //cmd.Parameters.AddWithValue("@TASK_ID", CustomerName);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        if (dt.Rows.Count > 0)
        //        {
        //            for (int i = 0; i < dt.Rows.Count; i++)
        //            {
        //                CustomerDetails customerInfo = new CustomerDetails();
        //                customerInfo.ESTAR_APPID = dt.Rows[i]["ESTAR_APPID"].ToString();
        //                customerInfo.TASK_ID = dt.Rows[i]["TASK_ID"].ToString();
        //                customerInfo.CUSTOMER_NAME = dt.Rows[i]["CUSTOMER_NAME"].ToString();
        //                customerInfo.FIELD_NOTE = dt.Rows[i]["FIELD_NOTE"].ToString();
        //                customerInfo.PRODUCT_TYPE = dt.Rows[i]["PRODUCT_TYPE"].ToString();
        //                customerInfo.BRANCH_NAME = dt.Rows[i]["BRANCH_NAME"].ToString();
        //                customerInfo.DTM_START_SEND = dt.Rows[i]["DTM_START_SEND"].ToString();
        //                customerInfo.DTM_END_SEND = dt.Rows[i]["DTM_END_SEND"].ToString();
        //                customerInfo.DTM_APPROVED = dt.Rows[i]["DTM_APPROVED"].ToString();
        //                customerInfo.SURVEYOR_NAME = dt.Rows[i]["SURVEYOR_NAME"].ToString();
        //                CustomerDetails.Add(customerInfo);
        //            }
        //        }
        //        con.Close();
        //    }
        //    return CustomerDetails;
        //}
        public string InsertCustomerDetails(CustomerDetails customerInfo)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RR1T07O\\SQLEXPRESS;Initial Catalog=ADO-MTF;User ID=sa;Password=123456");
        string strMessage = string.Empty;
        con.Open();
            SqlCommand cmd = new SqlCommand("insert into STATUS_PROGRESS2(ESTAR_APPID, TASK_ID, CUSTOMER_NAME, FIELD_NOTE, PRODUCT_TYPE, BRANCH_NAME, DTM_START_SEND, DTM_END_SEND, DTM_APPROVED, SURVEYOR_NAME) values(@ESTAR_APPID, @TASK_ID, @CUSTOMER_NAME, @FIELD_NOTE, @PRODUCT_TYPE, @BRANCH_NAME, @DTM_START_SEND, @DTM_END_SEND, @DTM_APPROVED, @SURVEYOR_NAME)", con);
            cmd.Parameters.AddWithValue("@ESTAR_APPID", customerInfo.ESTAR_APPID);
            cmd.Parameters.AddWithValue("@TASK_ID", customerInfo.TASK_ID);
            cmd.Parameters.AddWithValue("@CUSTOMER_NAME", customerInfo.CUSTOMER_NAME);
            cmd.Parameters.AddWithValue("@FIELD_NOTE", customerInfo.FIELD_NOTE);
            cmd.Parameters.AddWithValue("@PRODUCT_TYPE", customerInfo.PRODUCT_TYPE);
            cmd.Parameters.AddWithValue("@BRANCH_NAME", customerInfo.BRANCH_NAME);
            cmd.Parameters.AddWithValue("@DTM_START_SEND", customerInfo.DTM_START_SEND);
            cmd.Parameters.AddWithValue("@DTM_END_SEND", customerInfo.DTM_END_SEND);
            cmd.Parameters.AddWithValue("@DTM_APPROVED", customerInfo.DTM_APPROVED);
            cmd.Parameters.AddWithValue("@SURVEYOR_NAME", customerInfo.SURVEYOR_NAME);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                strMessage = customerInfo.TASK_ID + " inserted successfully";
            }
            else
            {
                strMessage = customerInfo.TASK_ID + " not inserted successfully";
            }
        con.Close();
            return strMessage;
        }


    }
}

