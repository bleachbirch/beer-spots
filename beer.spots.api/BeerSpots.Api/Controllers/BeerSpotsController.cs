using BeerSpots.App;
using BeerSpots.App.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BeerSpots.Api.Controllers
{
    [Route("api/spots")]
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
        [HttpPost("{radius}")]
        public async Task<string> GetAsync([FromBody] CoordinateDto coordinate, int radius)
        {
            var result = await _app.GetAsync(coordinate, radius);
            return JsonConvert.SerializeObject(result);
        }

        // GET api/<BeerSpotsController>/5
        [HttpPost]
        public async Task<string> GetAsync([FromBody] CoordinateDto coordinate)
        {
            var result = await _app.GetAsync(coordinate);
            return JsonConvert.SerializeObject(result);
        }

        // POST api/<BeerSpotsController>
        [HttpPost]
        [Route("create")]
        public async Task CreateAsync([FromBody] SpotDto spot)
        {
            await _app.CreateAsync(spot);
        }

        // PUT api/<BeerSpotsController>/5
        [HttpPut]
        public async Task UpdateAsync([FromBody] SpotDto value)
        {
            await _app.EditAsync(value);
        }

        // DELETE api/<BeerSpotsController>/5
        [HttpDelete]
        public async Task DeleteAsync([FromBody] CoordinateDto coordinate)
        {
            await _app.DeleteAsync(coordinate);
        }
    }
}
