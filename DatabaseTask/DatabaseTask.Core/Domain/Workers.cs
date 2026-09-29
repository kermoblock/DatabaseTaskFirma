using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Workers
    {
        public int Id { get; set; }

        public Company Company { get; set; }
        public Children Children { get; set; }
        public VacationList VacationList { get; set; }
        public CompanyPosition CompanyPosition { get; set; }
        public Sickness Sickness { get; set; }
        public HealthControl HealthControl { get; set; }
        public Permitions Permitions { get; set; }
        public Requests Requests { get; set; }
        public Lends Lends { get; set; }
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }

    }
}
