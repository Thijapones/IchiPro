using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.Controllers
{
    [Produces("application/json")]
    [Route("api/Banco")]
    public class BancoController : Controller
    {
        public string Get()
        {
            SqlConnection sqlConnection1 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT nome FROM db1.dbo.Customers where id=1";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            string x = (string)cmd.ExecuteScalar();
            // Data is accessible through the DataReader object here.

            sqlConnection1.Close();

            return x;
        }
    }
}