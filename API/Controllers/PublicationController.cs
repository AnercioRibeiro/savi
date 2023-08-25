using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublicationController : ControllerBase
    {
        public readonly ApplicationDbContext _dbContext;
        public PublicationController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Publication>>> GetAllPublication()
        {
            var publications = await _dbContext.Publications.ToListAsync();
            return publications;
        }
        [HttpPost]
        public async Task<ActionResult<List<Publication>>> CreatePublication([FromBody] Publication publication)
        {
            Publication pub = new()
            {
                Identifier = publication.Identifier,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
            await _dbContext.Publications.AddAsync(pub);
            await _dbContext.SaveChangesAsync();
            return Ok(pub);
        }
        [HttpGet("{id:int}")]
        public ActionResult GetPublication(int id)
        {
            var publication = _dbContext.Publications.FirstOrDefault(x => x.Id == id);
            return Ok(publication);
        }
    }
}
