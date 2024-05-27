using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pokemon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
       List<Pokemon> pokemons = new List<Pokemon> { 
                new Pokemon { 
                Id = 1,
                Name = "Bulbasaur",
                Type = "grass",
                Level = 10 },
            
                new Pokemon
                {
                    Id = 2,
                    Name = "Pikachu",
                    Type = "Lightning",
                    Level = 10
                },

                new Pokemon
                {
                    Id = 3,
                    Name = "Charizard",
                    Type = "Fire",
                    Level = 99
                }
            };

// GET: api/<PokemonController>
[HttpGet]
        public List<Pokemon> Get()
        {
            return pokemons;
        }

        // GET api/<PokemonController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            foreach (var item in pokemons)
            {
                if (item.Id == id)
                {
                    return Ok(item);
                }
            }
            return NotFound();
        }

        // POST api/<PokemonController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PokemonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PokemonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
