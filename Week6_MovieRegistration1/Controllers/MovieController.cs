using Microsoft.AspNetCore.Mvc;
using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week6_MovieRegistration1.Models;

namespace Week6_MovieRegistration1.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult List()
        {
            //'connect' represents the SQL database/workbench
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from movies";
                connect.Open();
                List<Movie> movies = connect.Query<Movie>(sql).ToList();
                connect.Close();
                return View(movies);
            }
        }
        public IActionResult Registration()
        {
            return View();
        }
    }
}
