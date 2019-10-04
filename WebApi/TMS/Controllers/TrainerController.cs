using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMS.Interface;
using TMS.Models;
using TMS.Services;

namespace TMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerController : ControllerBase
    {
        ITrainerServices services = new TrainerService();
        // GET: api/Trainer
        [HttpGet]
        public Dictionary<int, Trainer> Get()
        {
            return services.Read();
        }

        // GET: api/Trainer/5
        [HttpGet("{id}", Name = "Get")]
        public Trainer Get(int id)
        {
            return services.Read(id);
        }

        // POST: api/Trainer
        [HttpPost]
        public void Post(Trainer trainer)
        {
            services.Create(trainer);
        }

        // PUT: api/Trainer/5
        [HttpPut("{id}")]
        public void Put(int id, Trainer trainer)
        {
            services.Update(id, trainer);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            services.Delete(id);
        }
    }
}
