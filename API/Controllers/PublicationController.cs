using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult GetPublications()
        {
            var publications = _dbContext.Publications.ToList();
            return Ok(publications);
        }
        [HttpPost]
        public ActionResult Post(Publication publication)
        {
            Publication pub = new()
            {
                Identifier = publication.Identifier,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
            _dbContext.Publications.Add(pub);
            _dbContext.SaveChanges();
            return Ok(pub);
        }
    }
}
