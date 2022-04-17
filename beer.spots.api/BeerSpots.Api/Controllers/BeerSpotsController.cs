using BeerSpots.App;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BeerSpots.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerSpotsController : ControllerBase
    {
        private readonly ISpotInteractor _app;
        public BeerSpotsController(ISpotInteractor app)
        {
            _app = app;
        }

        // GET: api/<BeerSpotsController>
        [HttpGet]
        public async Task<IEnumerable<string>> GetAsync()
        {
            var result = await _app.GetAsync(default, default);
            return result.Select(x => JsonConvert.SerializeObject(x));
        }

        // GET api/<BeerSpotsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BeerSpotsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BeerSpotsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BeerSpotsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
