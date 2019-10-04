using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMS.Models;
using TMS.Services;

namespace TMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraineesController : ControllerBase
    {
        TraineeService services = new TraineeService();
        // GET: api/Trainees
        [HttpGet]
        public Dictionary<int, Trainee> Get()
        {
            return services.Read();
        }

        // GET: api/Trainees/5
        [HttpGet("{id}")]
        public Trainee Get(int id)
        {
            return services.Read(id);
        }

        // POST: api/Trainees
        [HttpPost]
        public void Post(Trainee trainee)
        {
            services.Create(trainee);
        }

        // PUT: api/Trainees/5
        [HttpPut("{id}")]
        public void Put(int id, Trainee trainee)
        {
            services.Update(id, trainee);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            services.Delete(id);
        }
    }
}
