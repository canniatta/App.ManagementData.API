using App.ManagementData.BusinessLayer.BindingModels;
using App.ManagementData.DataAccess.Context;
using App.ManagementData.DataAccess.Models;

namespace App.ManagementData.BusinessLayer.ReferenceData
{
    public class Reference
    {
        private readonly DBContext dbContext;
        public Reference(DBContext db)
        {
            dbContext = db;
        }
        public async Task<Tcustomer?> getDataCustomer(long idCustomer)
        {
            Tcustomer? result = await dbContext.Tcustomers.FindAsync(idCustomer);
            return result;
        }
        public async Task<(bool, Tcustomer)> InsertCustomer(BMCustomer data)
        {
            Tcustomer tCustomer = new();
            try
            {
                tCustomer.FirstName = data.FirstName;
                tCustomer.MiddleName = data.MiddleName;
                tCustomer.LastName = data.LastName;
                tCustomer.FullName = data.FullName;
                tCustomer.BirthDate = data.BirthDate;
                tCustomer.BirthPlace = data.BirthPlace;
                tCustomer.Idsex = data.IDSex;
                tCustomer.NoHandphone = data.NoHandphone;
                tCustomer.Age = data.Age;
                tCustomer.Idno = data.IDNo;
                tCustomer.Idtype = data.IDType;
                await dbContext.AddAsync(tCustomer);
                await dbContext.SaveChangesAsync();

                return (true, tCustomer);
            }
            catch (Exception)
            {
                return (false, tCustomer);
            }

        }
    }
}
