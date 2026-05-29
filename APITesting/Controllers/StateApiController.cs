using APITesting.Controllers.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APITesting.Controllers
{//  [Route("api/[controller]")]
    [ApiController]
    public class StateApiController : ControllerBase
    {

        [HttpGet()]
        [Route("api/allstates")]
        public List<State> GetAllStates()
        {
            List<State> lst = GetStates();
            return lst;
        }
        [HttpGet("api/state/{id}")]
        public State GetState(int id)
        {
            State st = GetStates().FirstOrDefault(e => e.StateId.Equals(id));
            return st;
        }


        [NonAction]
        public List<State> GetStates()
        {
            List<State> states = new List<State>()
            {
                new State(){StateId=1,Statename="Maharashtra"},
                new State(){StateId=2,Statename="Gujarat"},
                new State(){StateId=3,Statename="Rajasthan"},
                new State(){StateId=4,Statename="Punjab"},
                new State(){StateId=5,Statename="Goa"},
                new State(){StateId=6,Statename="Haryana"},
                new State(){StateId=7,Statename="Karnataka"},
                new State(){StateId=8,Statename="MP"},
                new State(){StateId=9,Statename="UP"},
                new State(){StateId=10,Statename="Kerala"}
            };
            return states;
        }
    }
}
