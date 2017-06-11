using System.Collections.Generic;
using System.Threading.Tasks;
using ASPCoreAngular.Controllers.Resources;
using ASPCoreAngular.Models;
using ASPCoreAngular.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPCoreAngular.Controllers
{
    public class BreedsController : Controller
    {
        private readonly AppDbContext context;

        public BreedsController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet("/api/breeds")]
        public async Task<IEnumerable<Breed>> GetBreeds()
        {
            return await context.Breeds.Include(b => b.Sheep)
                                       .ToListAsync();;
        }
    }
}