using HMSEntity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HospitalUI.Controllers
{
    public class HospitalController : Controller
    {
        public IActionResult Index()
        {
            List<Hospital> hospList = new List<Hospital>();
            using (var client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://localhost:44342/api/hospital");
                //builder.Query = "userName=" + userName + "&passWord=" + password;
                
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var responseTask = client.GetAsync(builder.Uri).Result;

                if (responseTask.IsSuccessStatusCode)
                {
                    var JsonContent = responseTask.Content.ReadAsStringAsync().Result;
                    hospList = JsonConvert.DeserializeObject<List<Hospital>>(JsonContent);
                }
            }
            return View(hospList);
        }
    }
}
