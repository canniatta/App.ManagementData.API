using App.ManagementData.BusinessLayer.BindingModels;

namespace App.ManagementData.BusinessLayer.Interface
{
    internal interface IBOCustomer
    {
        Task<(bool, string, BMCustomer)> ProcessGetCustomer(long idCustomer);
        Task<(bool, string, BMCustomer)> InsertDataCustomer(BMCustomer data);
    }
}
