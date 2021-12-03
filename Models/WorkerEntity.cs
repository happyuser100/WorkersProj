using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkersProj.Models
{
    public class WorkerEntity
    {
        public int WorkerId { get; set; }
        public string WorkerName { get; set; }
        public int WorkerNumber { get; set; }
        public string WorkerPhone { get; set; }
        public string WorkerEmail { get; set; }
        public float WorkerSalary { get; set; }        
    }
}
