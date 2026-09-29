using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class CompanyPosition
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string PositionName { get; set; }
        [MaxLength(255)]
        public string PositionDuties { get; set; }
        public int Pay { get; set; }

    }
}
