using Microsoft.AspNetCore.Mvc;
using Shape.WebUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shape.WebUi.Controllers
{
    public class UserController : Controller
    {
        private readonly UserContext _Db;
        public UserController(UserContext Db)
        {
            _Db = Db;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(User Obj)
        {

            _Db.Users.Add(Obj);
            await _Db.SaveChangesAsync();

            return View();
        }

    }
}

