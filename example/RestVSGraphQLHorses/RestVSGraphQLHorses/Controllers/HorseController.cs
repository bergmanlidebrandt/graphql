using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using RestVSGraphQLHorses.Db;
using RestVSGraphQLHorses.Models;
using Swashbuckle.Swagger.Annotations;

namespace RestVSGraphQLHorses.Controllers
{
    public class HorseController : ApiController
    {
        // GET api/values
        [SwaggerOperation("GetAll")]
        public List<Horse> Get()
        {
            return Database.GetHorses();
        }

        // GET api/values/5
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public Horse Get(int id)
        {
            return Database.GetHorse(id);
        }

        // POST api/values
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [SwaggerOperation("Update")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [SwaggerOperation("Delete")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Delete(int id)
        {
        }
    }
}
