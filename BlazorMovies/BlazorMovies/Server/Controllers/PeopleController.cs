using BlazorMovies.Server.Helpers;
using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorMovies.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController
    {
        private readonly ApplicationDbContext context;
        private readonly IFileStorageService fileStorageService;

        public PeopleController(ApplicationDbContext context,
            IFileStorageService fileStorageService)
        {
            this.context = context;
            this.fileStorageService = fileStorageService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Person>>> Get()
        {
            return await context.Actors.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Person person)
        {

            if (!string.IsNullOrWhiteSpace(person.Picture))
            {
                var personPicture = Convert.FromBase64String(person.Picture);
                person.Picture = await fileStorageService.SaveFile(personPicture, ".jpg", "people");
            }

            context.Add(person);
            await context.SaveChangesAsync();
            return person.Id;
        }
    }
}
