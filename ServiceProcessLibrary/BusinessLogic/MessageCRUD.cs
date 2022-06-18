using ServiceProcessLibrary.DataAccess;
using ServiceProcessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.BusinessLogic
{
    public class MessageCRUD
    {
        public static int CreateMessage (string clientsEmail,
                                         string subject,
                                         string text,
                                         string repairersEmail,
                                         DateTime date,
                                         Enums.MessageStatus messageStatus)
        {
            Message data = new Message
            {
                ClientsEmailAddress = clientsEmail,
                Subject = subject,
                Text = text,
                RepairersEmailAddress = repairersEmail,
                Date = date,
                Status = messageStatus
            };

            string sql = @"INSERT INTO dbo.Message (ClientsEmailAddress, Subject, Text, RepairersEmailAddress, Date, Status)
                           VALUES (@ClientsEmailAddress, @Subject, @Text, @RepairersEmailAddress, @Date, @Status);";

            return SSMSDataAccess.SaveData(sql, data);
        }
    }
}
