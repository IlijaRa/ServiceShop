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
        public static int CreateNotification(string clientsEmail,
                                            string title,
                                            string text,
                                            int billsId,
                                            int repairerId)
        {
            Notification data = new Notification
            {
                ClientsEmailAddress = clientsEmail,
                Title = title,
                Text = text,
                BillId = billsId,
                RepairerId = repairerId,
            };

            string sql = @"INSERT INTO dbo.Notification (ClientsEmailAddress, Title, Text, BillId, RepairerId)
                           VALUES (@ClientsEmailAddress, @Title, @Text, @BillId, @RepairerId);";

            return SSMSDataAccess.SaveData(sql, data);
        }

        public static List<Notification> LoadNotifications()
        {
            string sql = @"SELECT *
                           FROM dbo.Notification;";

            return SSMSDataAccess.LoadData<Notification>(sql);
        }

    }
}
