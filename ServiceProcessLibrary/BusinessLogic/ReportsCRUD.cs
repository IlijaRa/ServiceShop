using ServiceProcessLibrary.DataAccess;
using ServiceProcessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.BusinessLogic
{
    public class ReportsCRUD
    {
        public static int CreateMalfunctionRequest(string clientsName,
                                                   string clientsSurname,
                                                   string clientsemailAddress,
                                                   string description,
                                                   Enums.RequestType requestType,
                                                   Enums.StateType stateType,
                                                   string paymentType,
                                                   DateTime date,
                                                   int clientId)
        {
            Request data = new Request
            {
                ClientsName = clientsName,
                ClientsSurname = clientsSurname,
                ClientsEmailAddress = clientsemailAddress,
                Description = description,
                RequestType = requestType,
                StateType = stateType,
                PaymentType = paymentType,
                Date = date,
                ClientId = clientId
            };

            string sql = @"INSERT INTO dbo.Request (ClientsName, ClientsSurname, ClientsEmailAddress, Description, RequestType, StateType, PaymentType, Date, ClientId)
                           VALUES (@ClientsName, @ClientsSurname, @ClientsEmailAddress, @Description, @RequestType, @StateType, @PaymentType, @Date, @ClientId);";

            return SSMSDataAccess.SaveData(sql, data);
        }
    }
}
