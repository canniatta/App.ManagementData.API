using System;
using System.Collections.Generic;

namespace App.ManagementData.DataAccess.Models
{
    public partial class TcustomerAddress
    {
        public long IdcustomerAddress { get; set; }
        public long Idcustomer { get; set; }
        public int AddressType { get; set; }
        public string Address { get; set; } = null!;
        public string? CityCode { get; set; }
        public string? ProvinceCode { get; set; }
        public string PostalCode { get; set; } = null!;

        public virtual Tcustomer IdcustomerNavigation { get; set; } = null!;
    }
}
