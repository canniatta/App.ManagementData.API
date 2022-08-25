using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.ManagementData.MVC.Models
{
    public class CustomerViewModel
    {
        public long IDCustomer { get; set; }
        [DisplayName("First Name")] public string? FirstName { get; set; } = string.Empty;
        [DisplayName("Middle Name")] public string? MiddleName { get; set; } = string.Empty;
        [DisplayName("Last Name")] public string? LastName { get; set; } = string.Empty;
        [Required][DisplayName("Full Name")] public string FullName { get; set; } = string.Empty;
        [Required][DisplayName("Birth Date")][DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)] 
        public DateTime BirthDate { get; set; }
        [Required][DisplayName("Birth Place")] public string BirthPlace { get; set; } = string.Empty;
        [Required][DisplayName("Sex")] public string IDSex { get; set; } = string.Empty;
        [Required][DisplayName("No Handphone")] public string NoHandphone { get; set; } = string.Empty;
        [Required][DisplayName("Age")] public int Age { get; set; }
        [Required][DisplayName("ID Number")] public string IDNo { get; set; } = string.Empty;
        [Required][DisplayName("ID Type")] public string IDType { get; set; } = string.Empty;
    }
}
