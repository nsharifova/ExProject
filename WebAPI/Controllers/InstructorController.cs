using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : Controller
    {
        private readonly IInstructorManager _instructorManager;

        public InstructorController(IInstructorManager instructorManager)
        {
            _instructorManager = instructorManager;
        }

        [HttpGet("getall")]
        public List<Instructor> GetCategories()
        {
            return _instructorManager.GetAll();
        }

        [HttpPost("add")]
        public Instructor Add(Instructor instructor)
        {
            _instructorManager.Add(instructor);
            return instructor;
        }
    }
}
