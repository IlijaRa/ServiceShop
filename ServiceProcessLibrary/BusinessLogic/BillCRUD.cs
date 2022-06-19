using ServiceProcessLibrary.DataAccess;
using ServiceProcessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.BusinessLogic
{
    public class BillCRUD
    {
        public static int CreateBill(string billName,
                                                   string enterpriseName,
                                                   string enterpriseAddress,
                                                   string clientsName,
                                                   string clientsSurname,
                                                   string clientsAddress,
                                                   double price,
                                                   string spentMaterials,
                                                   string termsConditions)
        {
            Bill data = new Bill
            {
                Name = billName,
                EnterpriseName = enterpriseName,
                EnterpriseAddress = enterpriseAddress,
                ClientsName = clientsName,
                ClientsSurname = clientsSurname,
                ClientsEmailAddress = clientsAddress,
                Price = price,
                SpentMaterials = spentMaterials,
                TermsAndConditions = termsConditions,
                RepairerId = CurrentRepairerInfo.Id
            };

            string sql = @"INSERT INTO dbo.Bill (Name, EnterpriseName, EnterpriseAddress, ClientsName, ClientsSurname, ClientsEmailAddress, Price, SpentMaterials, TermsAndConditions, RepairerId)
                           VALUES (@Name, @EnterpriseName, @EnterpriseAddress, @ClientsName, @ClientsSurname, @ClientsEmailAddress, @Price, @SpentMaterials, @TermsAndConditions, @RepairerId);";

            return SSMSDataAccess.SaveData(sql, data);
        }
    }
}
