using Data.Dtos;
using Data.Entities;
using Data.Reponsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BysLicense.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectReponsitory _projectReponsitory;

        public HomeController()
        {
            _projectReponsitory = new ProjectReponsitory();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public HttpMe GetLicense()
        //{
        //    var response = new BaseResponse<Project>
        //    {
        //        Data = _projectReponsitory.GetProjectByCode(""),
        //        Status = true
        //    };

        //    return await Task.FromResult(response);
        //}
    }
}