using App.ManagementData.BusinessLayer.BindingModels;
using App.ManagementData.BusinessLayer.BusinessObject;
using App.ManagementData.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace App.ManagementData.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly BOCustomer boCustomer;
        public CustomerController(DBContext db)
        {
            boCustomer = new(db);
        }
        [Route("GetCustomerByID")]
        [HttpGet]
        public async Task<IActionResult> GetDataCustomerById([FromQuery] long idcustomer)
        {
            var result = await boCustomer.ProcessGetCustomer(idcustomer);
            if (!result.Item1)
                return BadRequest(result.Item3);

            
            return Ok(result.Item3);
        }
        [Route("GetAllCustomer")]
        [HttpGet]
        public async Task<IActionResult> GetAllDataCustomer()
        {
            var result = await boCustomer.GetAllDataCustomer();
            if (!result.Item1)
                return BadRequest(result.Item3);


            return Ok(result.Item3);
        }
        [Route("AddNewCustomer")]
        [HttpPost]
        public async Task<IActionResult> InsertDataCustomer(BMCustomer dataCustomer)
        {
            var result = await boCustomer.InsertDataCustomer(dataCustomer);
            if (!result.Item1)
                return BadRequest(result.Item3);


            return Ok(result.Item3);
        }
    }
}
