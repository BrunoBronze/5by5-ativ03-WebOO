using System.Collections.Generic;
using System.Web.Http;
using Data;
using Model;
using Proxy;

namespace WebAPI.Controllers
{
    public class PizzaController : ApiController
    {
        // GET: Pizza
        public IEnumerable<Pizza> Get()
        {
            return new PizzaDB().Select();
        }

        public bool Post([FromBody] Pizza pizza)
        {
            return new PizzaDB().Insert(pizza);
        }
    }
}