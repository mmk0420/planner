using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planner
{
    public class PlannerSaveData
    {
        public List<PlannerTask> Tasks { get; set; }
        public long? VkId { get; set; }
        public string VkToken { get; set; }
    }
}
