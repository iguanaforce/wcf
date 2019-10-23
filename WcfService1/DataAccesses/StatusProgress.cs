using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using WcfService1.DataContracts;
using WcfService1.Utils;

namespace WcfService1.DataAccess
{
    public class StatusProgress
    {
        private SqlConnection connection;
        public StatusProgress()
        {
            Connector connector = new Connector();
            this.connection = connector.Connection;
        }

        public List<CustomerDetails> GetCustomerDetails(string CustomerName)
        {
            List<CustomerDetails> CustomerDetails = null;
            try
            {
                this.connection.Open();
                CustomerDetails = new List<CustomerDetails>();
                {
                    SqlCommand cmd = new SqlCommand("select ESTAR_APPID, TASK_ID, CUSTOMER_NAME, FIELD_NOTE, PRODUCT_TYPE, BRANCH_NAME, DTM_START_SEND, DTM_END_SEND, DTM_APPROVED, SURVEYOR_NAME  from STATUS_PROGRESS2 where CUSTOMER_NAME = @customerName ", this.connection);
                    cmd.Parameters.AddWithValue("@customerName", CustomerName);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        CustomerDetails customerInfo = new CustomerDetails();
                        customerInfo.ESTAR_APPID = reader["ESTAR_APPID"].ToString();
                        customerInfo.TASK_ID = reader["TASK_ID"].ToString();
                        customerInfo.CUSTOMER_NAME = reader["CUSTOMER_NAME"].ToString();
                        customerInfo.FIELD_NOTE = reader["FIELD_NOTE"].ToString();
                        customerInfo.PRODUCT_TYPE = reader["PRODUCT_TYPE"].ToString();
                        customerInfo.BRANCH_NAME = reader["BRANCH_NAME"].ToString();
                        customerInfo.DTM_START_SEND = reader["DTM_START_SEND"].ToString();
                        customerInfo.DTM_END_SEND = reader["DTM_END_SEND"].ToString();
                        customerInfo.DTM_APPROVED = reader["DTM_APPROVED"].ToString();
                        customerInfo.SURVEYOR_NAME = reader["SURVEYOR_NAME"].ToString();
                        CustomerDetails.Add(customerInfo);
                    }
                }
            }catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return CustomerDetails;
        }

        public string InsertCustomerDetails(CustomerDetails customerInfo)
        {
            string strMessage = "";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand("insert into STATUS_PROGRESS2(ESTAR_APPID, TASK_ID, CUSTOMER_NAME, FIELD_NOTE, PRODUCT_TYPE, BRANCH_NAME, DTM_START_SEND, DTM_END_SEND, DTM_APPROVED, SURVEYOR_NAME) values(@ESTAR_APPID, @TASK_ID, @CUSTOMER_NAME, @FIELD_NOTE, @PRODUCT_TYPE, @BRANCH_NAME, @DTM_START_SEND, @DTM_END_SEND, @DTM_APPROVED, @SURVEYOR_NAME)", this.connection);
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
                if(result == 1)
                {
                    strMessage = customerInfo.TASK_ID + " inserted successfully";
                }
                else
                {
                    strMessage = customerInfo.TASK_ID + " not inserted successfully";
                }
            }
            catch(SqlException e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return strMessage;
        }
    }
}