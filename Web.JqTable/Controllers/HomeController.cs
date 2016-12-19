﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Get()
        {
            var list = new List<Employee> {
              new Employee { FirstName="Ehasanul", LastName="Hoque", Office="Orion Informatics Ltd", Position="Senior Software Engineer", StartDate="5 Mar 2014", Salary="5 Mar 2016"},
              new Employee { FirstName="Ehasanul", LastName="Hoque", Office="Orion Informatics Ltd", Position="Senior Software Engineer", StartDate="5 Mar 2014", Salary="5 Mar 2016"},
              new Employee { FirstName="Ehasanul", LastName="Hoque", Office="Orion Informatics Ltd", Position="Senior Software Engineer", StartDate="5 Mar 2014", Salary="5 Mar 2016"},
              new Employee { FirstName="Ehasanul", LastName="Hoque", Office="Orion Informatics Ltd", Position="Senior Software Engineer", StartDate="5 Mar 2014", Salary="5 Mar 2016"},
               new Employee { FirstName="Ehasanul", LastName="Hoque", Office="Orion Informatics Ltd", Position="Senior Software Engineer", StartDate="5 Mar 2014", Salary="5 Mar 2016"},
             new Employee { FirstName="Ehasanul", LastName="Hoque", Office="Orion Informatics Ltd", Position="Senior Software Engineer", StartDate="5 Mar 2014", Salary="5 Mar 2016"},
              new Employee { FirstName="Ehasanul", LastName="Hoque", Office="Orion Informatics Ltd", Position="Senior Software Engineer", StartDate="5 Mar 2014", Salary="5 Mar 2016"},
               new Employee { FirstName="Ehasanul", LastName="Hoque", Office="Orion Informatics Ltd", Position="Senior Software Engineer", StartDate="5 Mar 2014", Salary="5 Mar 2016"},
                new Employee { FirstName="Ehasanul", LastName="Hoque", Office="Orion Informatics Ltd", Position="Senior Software Engineer", StartDate="5 Mar 2014", Salary="5 Mar 2016"},
               new Employee { FirstName="Ehasanul", LastName="Hoque", Office="Orion Informatics Ltd", Position="Senior Software Engineer", StartDate="5 Mar 2014", Salary="5 Mar 2016"},
                new Employee { FirstName="Ehasanul", LastName="Hoque", Office="Orion Informatics Ltd", Position="Senior Software Engineer", StartDate="5 Mar 2014", Salary="5 Mar 2016"},
                new Employee { FirstName="Ehasanul", LastName="Hoque", Office="Orion Informatics Ltd", Position="Senior Software Engineer", StartDate="5 Mar 2014", Salary="5 Mar 2016"},
               new Employee { FirstName="Ehasanul", LastName="Hoque", Office="Orion Informatics Ltd", Position="Senior Software Engineer", StartDate="5 Mar 2014", Salary="5 Mar 2016"},
               new Employee { FirstName="Ehasanul", LastName="Hoque", Office="Orion Informatics Ltd", Position="Senior Software Engineer", StartDate="5 Mar 2014", Salary="5 Mar 2016"},
             new Employee { FirstName="Ehasanul", LastName="Hoque", Office="Orion Informatics Ltd", Position="Senior Software Engineer", StartDate="5 Mar 2014", Salary="5 Mar 2016"},
            new Employee { FirstName="Ehasanul", LastName="Hoque", Office="Orion Informatics Ltd", Position="Senior Software Engineer", StartDate="5 Mar 2014", Salary="5 Mar 2016"},                                                                                                                            new Employee { FirstName="Ehasanul", LastName="Hoque", Office="Orion Informatics Ltd", Position="Senior Software Engineer", StartDate="5 Mar 2014", Salary="5 Mar 2016"},
            new Employee { FirstName="Ehasanul", LastName="Hoque", Office="Orion Informatics Ltd", Position="Senior Software Engineer", StartDate="5 Mar 2014", Salary="5 Mar 2016"},
            };
            var dataTable = new DataTable { data = list,draw="1", recordsTotal=list.Count().ToString(),recordsFiltered=list.Count.ToString() };
          
            return Json(dataTable);
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
    public class DataTable
    {
        public string draw { get; set; }
        public string recordsTotal { get; set; }
        public string recordsFiltered { get; set; }
        public List<Employee> data { get; set; }
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public string StartDate { get; set; }
        public string Salary { get; set; }
    }
}