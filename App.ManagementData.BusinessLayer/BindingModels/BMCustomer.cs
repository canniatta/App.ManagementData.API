using System.ComponentModel.DataAnnotations;

namespace App.ManagementData.BusinessLayer.BindingModels
{
    public class BMCustomer
    {
        public long IDCustomer { get; set; }
        public string? FirstName { get; set; } = string.Empty;
        public string? MiddleName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        [Required] public string FullName { get; set; } = string.Empty;
        [Required] public DateTime BirthDate { get; set; }
        [Required] public string BirthPlace { get; set; } = string.Empty;
        [Required] public string IDSex { get; set; } = string.Empty;
        [Required] public string NoHandphone { get; set; } = string.Empty;
        [Required] public int Age { get; set; }
        [Required] public string IDNo { get; set; } = string.Empty;
        [Required] public string IDType { get; set; } = string.Empty;
    }
}
