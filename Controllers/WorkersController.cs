using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkersProj.Models;

namespace WorkersProj.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class WorkersController : ControllerBase
    {
            [HttpGet]
            [Route("GetWorkers")]
            public async Task<ActionResult> GetWorkers()
            //public List<WorkerEntity> GetWorkers()
            {
                List<WorkerEntity> workers = new List<WorkerEntity>();
                await Task.Delay(1000);

                return Ok(JsonConvert.SerializeObject(workers));
            }

    }
}
