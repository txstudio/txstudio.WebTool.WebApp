using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using txstudio.WebTool.ParameterCmdTextBuilder;

namespace txstudio.WebTool.WebApp.Controllers
{
    public class ToolController : Controller
    {
        private ParameterCmdTextService _service;

        public ToolController()
        {
            this._service = new ParameterCmdTextService();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ParameterCmdTextBuilder()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ParameterCmdTextBuilder(string cmd)
        {
            ViewBag.CSharpCode = this._service.Create(cmd);

            return View();
        }
    }
}