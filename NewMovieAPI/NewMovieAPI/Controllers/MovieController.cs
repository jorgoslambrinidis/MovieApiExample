using Microsoft.AspNetCore.Mvc;
using NewMovieAPI.Entities;
using NewMovieAPI.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewMovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        // GET: api/<MovieController>
        [HttpGet("Filmovi")]
        public async Task<IEnumerable<Movie>> GetMovie()
        {
            return await _movieService.GetMovies();
        }

        [HttpGet("Filmovi2")]
        public IEnumerable<Movie> GetMovie2()
        {
            return _movieService.GetMovies2();
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MovieController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
