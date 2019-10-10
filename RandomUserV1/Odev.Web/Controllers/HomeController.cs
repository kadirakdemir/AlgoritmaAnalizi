using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Odev.Web.Clients;
using Odev.Web.Models;
using Odev.Web.Services;
using Odev.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Odev.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserClientManager _userClientManager = new UserClientManager();
        private readonly RandomUserService _randomUserService = new RandomUserService();
       
        public ActionResult Index()
        {
            _userClientManager.Url("https://randomuser.me/api", "?nat=tr&results=10");
            var randomUsers = _userClientManager.GetRandomUsers();           
            return View(randomUsers);
        }
       
        [HttpPost]
        public ActionResult Create(IList<RandomUserViewModel> model)
        {
            if (ModelState.IsValid)
            {
                _randomUserService.AddList(model);
               return RedirectToAction("About");
            }
            return View();
        }

        public ActionResult About()
        {
            var randomUser = _randomUserService.GetAll();
            if (randomUser!=null)
            {
                return View(randomUser);
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            if (id != null)
            {
                var user = _randomUserService.GetById(id);                
                return View(user);
            }
            return View();
        }

        [HttpPost]
        public ActionResult DeleteConfirm(string id)
        {
            if (id!=null)
            {
                var user = _randomUserService.GetById(id);
                _randomUserService.Delete(user);
                return RedirectToAction(nameof(About));
            }
            return View();
        }

        [HttpGet]
        public ActionResult Exam()
        {
            var Question = _randomUserService.GetQuestion();
            if (Question!=null)
            {
                return View(Question);
            }
            return RedirectToAction(nameof(About));
        }

       
        [HttpPost]
        public ActionResult Exam(ExamViewModel model)
        {
            _randomUserService.AddAnswer(model);
            return RedirectToAction(nameof(About));
        }

        [HttpGet]
        public ActionResult Answer()
        {
            var answers= _randomUserService.GetAnswers();

            if (answers!=null)
            {
                return View(answers);
            }

            return RedirectToAction(nameof(About));
        }

    }
}