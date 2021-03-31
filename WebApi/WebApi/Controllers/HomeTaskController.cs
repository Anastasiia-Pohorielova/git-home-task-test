using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Services;
using WebApi.Dto;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeTaskController : ControllerBase
    {
        private readonly HomeTaskService _homeTaskService;

        public HomeTaskController(HomeTaskService homeTaskService)
        {
            _homeTaskService = homeTaskService;
        }
        // GET: api/HomeTask
        [HttpGet]
        public ActionResult<IEnumerable<CourseDto>> Get()
        {
            return Ok(_homeTaskService.GetAllHomeTasks().Select(homeTask => HomeTaskDto.FromModel(homeTask)));
        }

        // POST api/Course/
        [HttpPost]
        public ActionResult Post(HomeTaskDto value)
        {
           var createHomeTask = _homeTaskService.CreateHomeTask(value.ToModel());
            if (createHomeTask.HasErrors)
            {
                return BadRequest(createHomeTask.Errors);
            }
            return Accepted();
        }

        // GET api/Course/5
        [HttpGet("{id}")]
        public ActionResult<HomeTaskDto> Get(int id)
        {
            var homeTask = _homeTaskService.GetHomeTaskById(id);

            if (homeTask == null)
            {
                return NotFound();
            }

            return Ok(HomeTaskDto.FromModel(homeTask));
        }

        // PUT api/HomeTask/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] HomeTaskDto value)
        {
            var updateResult = _homeTaskService.UpdateHomeTask(value.ToModel());
            if (updateResult.HasErrors)
            {
                return BadRequest(updateResult.Errors);
            }
            return Accepted();
        }

        // DELETE api/HomeTask/5
        [HttpDelete("{id}")] 
        public ActionResult Delete(int id)
        {
            _homeTaskService.DeleteHomeTask(id);
            return Accepted();
        }
    }
}
