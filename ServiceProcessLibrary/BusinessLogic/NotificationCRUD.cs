using ServiceProcessLibrary.DataAccess;
using ServiceProcessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.BusinessLogic
{
    public class NotificationCRUD
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

        public static int CreateReport(string clientsEmail,
                                         string title,
                                         string details,
                                         int mark,
                                         int repairerId)
        {
            Report data = new Report
            {
                ClientsEmailAddress = clientsEmail,
                Title = title,
                Details = details,
                Mark = mark,
                RepairerId = repairerId,
            };

            string sql = @"INSERT INTO dbo.Report (ClientsEmailAddress, Title, Details, Mark, RepairerId)
                           VALUES (@ClientsEmailAddress, @Title, @Details, @Mark, @RepairerId);";

            return SSMSDataAccess.SaveData(sql, data);
        }
    }
}
