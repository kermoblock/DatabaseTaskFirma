using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class HealthControl
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string RecentIllnesses { get; set; }
        [MaxLength(255)]
        public string RecentHealthIssues { get; set; }
    }
}
