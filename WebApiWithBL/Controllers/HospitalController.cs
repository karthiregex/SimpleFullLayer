using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HMSEntity;
using BusinessLayer2;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiWithBL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        // GET: api/<HospitalController>
        [HttpGet]
        public List<Hospital> Get()
        {
            List<Hospital> hospitals = new List<Hospital>();
            HosipalBusinessLogics obj = new HosipalBusinessLogics();
            hospitals = obj.GetHospitalDetails();
            return hospitals;
        }

        // GET api/<HospitalController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HospitalController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HospitalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HospitalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
