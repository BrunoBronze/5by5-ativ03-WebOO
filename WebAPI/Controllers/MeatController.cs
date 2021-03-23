using System.Collections.Generic;
using System.Web.Http;
using Data;
using Model;

namespace WebAPI.Controllers
{
    public class MeatController : ApiController
    {
        // GET: api/Meat https://localhost:44385/api/Meat
        public IEnumerable<Meal> Get()
        {
            return new MealDB().Select();
        }

        public bool Post([FromBody] Meal meal)
        {
            return new MealDB().Insert(meal);
        }
    }
}