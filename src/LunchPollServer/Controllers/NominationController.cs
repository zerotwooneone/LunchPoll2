using System.Collections.Generic;
using LunchPollApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace LunchPollApi.Controllers
{
    [Route("api/[controller]")]
    public class NominationController : Controller
    {
        // GET api/nomination
        [HttpGet]
        public IEnumerable<Nomination> Get()
        {
            return new[] { new Nomination
            {
                Id = 99,
                Vetoes = 233,
                Name = "Something",
                Approves = 445
            }};
        }

        //// GET api/nomination/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // Patch api/nomination/approve
        [HttpPatch("approve")]
        public Nomination Approve([FromBody]Nomination nomination)
        {
            return new Nomination
            {
                Id = 1,
                Vetoes = 0,
                Name = "approved",
                Approves = 0
            };
        }

        // Patch api/nomination/veto
        [HttpPatch("veto")]
        public Nomination Veto([FromBody]Nomination nomination)
        {
            return new Nomination
            {
                Id = 1,
                Vetoes = 0,
                Name = "vetoed",
                Approves = 0
            };
        }

        // Post api/nomination
        [HttpPost]
        public Nomination Post([FromBody]Nomination nomination)
        {
            return new Nomination
            {
                Id = 99,
                Vetoes = 0,
                Name = nomination.Name,
                Approves = 0
            };
        }

        //// DELETE api/nomination/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
