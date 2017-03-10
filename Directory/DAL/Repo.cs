using Directory.Data.DirectoryTableAdapters;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Directory.DAL
{
    public class Repo
    {
        private DetailTableAdapter dta;

        public Repo()
        {
            this.dta = new DetailTableAdapter();

        }

        public void ClearRecords()
        {
            try
            {
                Convert.ToInt32(dta.usp_clear_records());
            }
            catch
            {
                //
            }
        }

        public DataTable GetNamesInOrder()
        {
            var connection = ConfigurationManager.ConnectionStrings["OutsuranceConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connection);

            try
            {
                conn.Open();
                using (conn)
                {
                    SqlCommand command = new SqlCommand()
                    {
                        Connection = conn,
                        CommandType = CommandType.StoredProcedure
                    };
                    command.CommandText = "usp_order_names";

                    var table = new DataTable();
                    table.Load(command.ExecuteReader());
                    return table;
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public int InsertRecord(string firstName, string lastname, string address, string phoneNumber)
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(dta.usp_insert_record(firstName, lastname, address, phoneNumber));
                return result;
            }
            catch
            {
                return 0;
            }
        }


        public DataTable GetAddressesInOrder()
        {
            var connection = ConfigurationManager.ConnectionStrings["OutsuranceConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connection);

            try
            {
                conn.Open();
                using (conn)
                {
                    SqlCommand command = new SqlCommand()
                    {
                        Connection = conn,
                        CommandType = CommandType.StoredProcedure
                    };
                    command.CommandText = "usp_order_addresses";
                    var table = new DataTable();
                    table.Load(command.ExecuteReader());
                    return table;
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
