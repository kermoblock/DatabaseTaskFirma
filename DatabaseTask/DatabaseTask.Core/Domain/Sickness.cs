using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Sickness
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string HealthIssue { get; set; }

        public DateTime OutOfWorkForHowLong { get; set; }
    }
}
