using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ParksNearMe.Models;

namespace ParksNearMe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Parks parks = SearchController.SearchPark(null);
            Dictionary<String, int> parkCountByState = new Dictionary<string, int>();
            foreach (Park park in parks.data)
            {
                String[] stateCodes = park.states.Split(",");
                foreach (String stateCode in stateCodes)
                {
                    if (parkCountByState.ContainsKey(stateCode))
                    {
                        parkCountByState[stateCode] = parkCountByState[stateCode] + 1;
                    }
                    else
                    {
                        parkCountByState.Add(stateCode, 1);
                    }
                }
            }


            string[] chartColors = new string[] { "rgb(255, 99, 132)", "rgb(255, 159, 64)", "rgb(255, 205, 86)", "rgb(75, 192, 192)", 
                                                  "rgb(54, 162, 235)", "rgb(153, 102, 255)", "rgb(201, 203, 207)", "#4dc9f6",
                                                "#f67019", "#f53794","#537bc4", "#acc236", "#166a8f", "#00a950", "#58595b","#8549ba" };
            Chart Model = new Chart
            {
                chartType = "doughnut",
                labels = String.Join(",", parkCountByState.Keys.Select(d => "'" + d + "'")),
                data = String.Join(",", parkCountByState.Values.Select(d => d)),
                chartTitle = "No. of parks by state",
                backgroundColors = String.Join(",", chartColors.Select(d => "'" + d + "'"))
            };

            return View(Model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
