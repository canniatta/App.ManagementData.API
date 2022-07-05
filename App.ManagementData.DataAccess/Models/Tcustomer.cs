using System;
using System.Collections.Generic;

namespace App.ManagementData.DataAccess.Models
{
    public partial class Tcustomer
    {
        public Tcustomer()
        {
            TcustomerAddresses = new HashSet<TcustomerAddress>();
        }

        public long Idcustomer { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string FullName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; } = null!;
        public string Idsex { get; set; } = null!;
        public string NoHandphone { get; set; } = null!;
        public int Age { get; set; }
        public string Idno { get; set; } = null!;
        public string Idtype { get; set; } = null!;

        public virtual ICollection<TcustomerAddress> TcustomerAddresses { get; set; }
    }
}
