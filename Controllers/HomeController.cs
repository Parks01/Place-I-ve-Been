using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;
using System.Collections.Generic;
using System;

namespace PlacesBeen.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet("/form")]
        public ActionResult FormFill()
        {
            return View("form");
        }
        [HttpPost("/result")]
        public ActionResult FormPost()
        {
            Place myPlace = new Place();
            myPlace.SetLocation(Request.Form["location"]);
            List<Place> allPlaces = Place.GetAll();
            return View("result", allPlaces);

        }
        [HttpGet("/list")]
        public ActionResult List()
        {
            List<Place> allPlaces = Place.GetAll();
            return View(allPlaces);
        }


        [HttpGet("/place/{id}")]
        public ActionResult PlaceInstance(int id)
        {   
            return View(Place.Find(id));

        }

    }
}
