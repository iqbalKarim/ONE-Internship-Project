using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace API.Controllers
{
    public class AppUserController : BaseApiController
    {
        public AppUserController()
        {
        }

        [HttpGet("GetUsers")]
        public List<AppUser> GetUsers()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-GMOA06LL\SQLEXPRESS;Initial Catalog=ONE_ProjectDatabase;Trusted_Connection=True");
            SqlDataAdapter sqlAda = new SqlDataAdapter("Select * from AppUsers",connection);
            DataTable data = new DataTable();
            sqlAda.Fill(data);

            List<AppUser> list = new List<AppUser>();
            list = (from DataRow dr in data.Rows 
                    select new AppUser(Convert.ToInt32(dr["Id"]), dr["UserName"].ToString())
                    ).ToList();
            
            return list;
        }
    }
}