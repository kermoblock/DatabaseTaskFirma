using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Permitions
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string PermitionName { get; set; }
        [MaxLength(255)]
        public string AccessToWhat { get; set; }
        [MaxLength(255)]
        public string ControlOverWhat { get; set; }
    }
}
