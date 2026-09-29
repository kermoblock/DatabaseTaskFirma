using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Lends
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string LendingWhat { get; set; }
        public DateTime LendStart { get; set; }
        public DateTime LendEnd { get; set; }
    }
}
