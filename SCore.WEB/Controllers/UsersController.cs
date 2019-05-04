﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SCore.BLL.Interfaces;
using SCore.Models;

namespace SCore.WEB.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService userService;
        public UsersController(IUserService _userService)
        {
            userService = _userService;

        }
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View(userService.GetAll());
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            User user = userService.Get(id);
            return View(user);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                userService.Create(user);
                return RedirectToAction("Index");
            }

            return View(user);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(string id)
        {
            User user = userService.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                userService.Edit(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(string id)
        {
            User user = userService.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(string id)
        {
            userService.Delete(id);
            return RedirectToAction("Index");
        }

    }
}