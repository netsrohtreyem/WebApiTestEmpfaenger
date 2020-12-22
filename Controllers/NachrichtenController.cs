using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiTestEmpfaenger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NachrichtenController : ControllerBase
    {
        // GET: api/<NachrichtenController>?value1=...&value2=.....
        // returns List with value1 und value2
        [HttpGet]
        public IEnumerable<string> Get(string value1 = "",string value2="")
        {
            List<string> tmp = new List<string>();
            tmp.Add(value1);
            tmp.Add(value2);

            return tmp;
        }

        // GET api/<NachrichtenController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return id.ToString();
        }

        // POST api/<NachrichtenController> with json format , returns list of values
        [HttpPost]
        public IEnumerable<string> Post([FromBody] string value="")
        {
            Dictionary<string, string> tmp = new Dictionary<string, string>();
            List<string> ergebnis = new List<string>();
            JObject test = null;

            try
            {
              test = JObject.Parse(value);

              tmp = test.ToObject<Dictionary<string, string>>();

                foreach(string s in tmp.Values)
                {
                    ergebnis.Add(s);
                }
            }
            catch(Exception)
            { }

            return ergebnis;
        }

        // PUT api/<NachrichtenController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NachrichtenController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
