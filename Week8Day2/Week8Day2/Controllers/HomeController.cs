using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;
using RestSharp;
using Week8Day2.Models;

namespace Week8Day2.Controllers
{
    public class HomeController : Controller
    {
       

        public ActionResult Index()
        {

            var client = new RestClient("https://openapi.etsy.com/v2/listings/active/");

            var request = new RestRequest(Method.GET);
            request.AddParameter("api_key", ConfigurationManager.AppSettings["MyEtsyKey"]);
            request.AddParameter("includes", "MainImage");
            var results2 = Json(client.Execute(request));

            RestResponse<Results> results = (RestResponse<Results>)client.Execute<Results>(request);
        //    results.Data.results[0].image_id;
            return View(results.Data.results);
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
    }
}