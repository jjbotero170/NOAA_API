using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace USEnergy_API.Controllers
{
    public class HomeController : Controller
    {
        HttpClient httpClient;

        static string BASE_URL = "http://api.eia.gov/series/";  // website where data is avalible
                                                                // http://api.eia.gov/series/?api_key={ApiKey}&series_id={seriesId}
        static string API_KEY = "4e5d9362e3c1e574c64731f0f832c0d5"; //Add your API key here inside ""

        // https://www.eia.gov/opendata/register.php

        public IActionResult Index()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string USEnergy_API_PATH = BASE_URL + "/?series?limit=20"; //parks?limit=20";
            string data = "";

            //Parks parks = null;

            httpClient.BaseAddress = new Uri(USEnergy_API_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(USEnergy_API_PATH).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    data = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!data.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    // parks = JsonConvert.DeserializeObject<Parks>(data);
                }
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return View();
        }
    }
}

