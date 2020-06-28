using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParksNearMe.Models;

namespace ParksNearMe.Controllers
{
    public class SearchController : Controller
    {
        HttpClient httpClient;

        static string BASE_URL = "https://developer.nps.gov/api/v1/";
        static string API_KEY = "mdBybOievMdeX3eYSC0MhFu3U7xRV18xHAPG04qb";

        public IActionResult SearchByState(String stateCode)
        {
            Parks allParks = null;
            if(!String.IsNullOrEmpty(stateCode))
            {
                allParks = SearchPark("stateCode=" + stateCode);
            }
            return View(allParks);
        }

        //public IActionResult SearchByStateCode(String stateCode)
        //{
        //    return View();
        //}

        public IActionResult SearchByCode(String parkCode)
        {
            Parks allParks = null;
            if (!String.IsNullOrEmpty(parkCode))
            {
                allParks = SearchPark("parkCode=" + parkCode);
            }
            return View(allParks);
        }

        public IActionResult SearchByName(String parkName)
        {
            Parks allParks = null;
            if (!String.IsNullOrEmpty(parkName))
            {
                allParks = SearchPark("q=" + parkName);
            }
            return View(allParks);
        }

        public Parks SearchPark(String param)
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string NATIONAL_PARK_API_PATH = BASE_URL + "/parks?limit=20&" + param;
            string parksData = "";

            Models.Parks parks = null;

            httpClient.BaseAddress = new Uri(NATIONAL_PARK_API_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(NATIONAL_PARK_API_PATH).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    parksData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!parksData.Equals(""))
                {
                    parks = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Parks>(parksData);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return parks;
        }
    }
}
