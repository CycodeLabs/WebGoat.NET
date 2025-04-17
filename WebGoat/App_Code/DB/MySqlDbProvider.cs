using System;
using System.Data;
using MySql.Data.MySqlClient;
using log4net;
using System.Reflection;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace OWASP.WebGoat.NET.App_Code.DB
{
    public class MySqlDbProvider : IDbProvider
    {
        //... (rest of the code remains the same)

        public string GetEmailByCustomerNumber(string num)
        {
            string output = "";
            try
            {
                output = (String)MySqlHelper.ExecuteScalar(_connectionString, "select email from CustomerLogin where customerNumber = @num", new MySqlParameter("@num", num));
            }
            catch (Exception ex)
            {
                log.Error("Error getting email by customer number", ex);
                output = ex.Message;
            }

            return output;
        }

        //... (rest of the code remains the same)
    }
}