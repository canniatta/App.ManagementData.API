using App.ManagementData.BusinessLayer.BindingModels;
using App.ManagementData.BusinessLayer.Interface;
using App.ManagementData.BusinessLayer.ReferenceData;
using App.ManagementData.DataAccess.Context;

namespace App.ManagementData.BusinessLayer.BusinessObject
{
    public class BOCustomer : IBOCustomer
    {
        private readonly Reference boReference;
        public BOCustomer(DBContext db)
        {
            boReference = new(db);
        }
        public async Task<(bool, string, BMCustomer)> ProcessGetCustomer(long idCustomer)
        {
            BMCustomer dataCustomer = new();
            var getData = await boReference.getDataCustomer(idCustomer);
            if (getData is null)
            {
                return (false, "Data Customer Not Found", dataCustomer);
            }

            dataCustomer.FirstName = getData.FirstName;
            dataCustomer.MiddleName = getData.MiddleName;
            dataCustomer.LastName = getData.LastName;
            dataCustomer.FullName = getData.FullName;
            dataCustomer.BirthDate = getData.BirthDate;
            dataCustomer.BirthPlace = getData.BirthPlace;
            dataCustomer.IDSex = getData.Idsex;
            dataCustomer.NoHandphone = getData.NoHandphone;
            dataCustomer.Age = getData.Age;
            dataCustomer.IDNo = getData.Idno;
            dataCustomer.IDType = getData.Idtype;

            return (true, "Success", dataCustomer);
        }
        public async Task<(bool, string, List<BMCustomer>)> GetAllDataCustomer()
        {
            List<BMCustomer> AllDataCustomer = new();
            var getAllData = await boReference.getAllDataCustomer();
            if (getAllData is null)
            {
                return (false, "Data Customer Not Found", AllDataCustomer);
            }

            for (int i = 0; i < getAllData.Count; i++)
            {
                BMCustomer dataCustomer = new();
                dataCustomer.FirstName = getAllData[i].FirstName;
                dataCustomer.MiddleName = getAllData[i].MiddleName;
                dataCustomer.LastName = getAllData[i].LastName;
                dataCustomer.FullName = getAllData[i].FullName;
                dataCustomer.BirthDate = getAllData[i].BirthDate;
                dataCustomer.BirthPlace = getAllData[i].BirthPlace;
                dataCustomer.IDSex = getAllData[i].Idsex;
                dataCustomer.NoHandphone = getAllData[i].NoHandphone;
                dataCustomer.Age = getAllData[i].Age;
                dataCustomer.IDNo = getAllData[i].Idno;
                dataCustomer.IDType = getAllData[i].Idtype;

                AllDataCustomer.Add(dataCustomer);
            }
            
            return (true, "Success", AllDataCustomer);
        }
        public async Task<(bool, string, BMCustomer)> InsertDataCustomer(BMCustomer data)
        {
            BMCustomer dataCustomer = new();
            var getData = await boReference.InsertCustomer(data);
            if (!getData.Item1)
                return (false, "Insert Data Failed", dataCustomer);

            dataCustomer.FirstName = getData.Item2.FirstName;
            dataCustomer.MiddleName = getData.Item2.MiddleName;
            dataCustomer.LastName = getData.Item2.LastName;
            dataCustomer.FullName = getData.Item2.FullName;
            dataCustomer.BirthDate = getData.Item2.BirthDate;
            dataCustomer.BirthPlace = getData.Item2.BirthPlace;
            dataCustomer.IDSex = getData.Item2.Idsex;
            dataCustomer.NoHandphone = getData.Item2.NoHandphone;
            dataCustomer.Age = getData.Item2.Age;
            dataCustomer.IDNo = getData.Item2.Idno;
            dataCustomer.IDType = getData.Item2.Idtype;

            return (true, "Success", dataCustomer);
        }
    }
}
