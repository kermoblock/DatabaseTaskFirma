using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Company
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string Location { get; set; }

        [MaxLength(30)]
        public string Office { get; set; }
    }
}
