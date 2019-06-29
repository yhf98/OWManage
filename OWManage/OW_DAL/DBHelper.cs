using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace OWManage.OW_DAL
{
    public class DBHelper
    {
        private static string Sqlstring = ConfigurationManager.ConnectionStrings["SqlString"].ConnectionString.ToString();

    }
}