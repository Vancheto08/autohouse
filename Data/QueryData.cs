using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class QueryData
    {
        public static DataTable GetAllOrdersPayedWithCardForCustomers()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection())
            {
                string query = @"";
            }
            return dataTable;
        }
    }
}
