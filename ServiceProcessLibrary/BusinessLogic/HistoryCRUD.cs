using ServiceProcessLibrary.DataAccess;
using ServiceProcessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.BusinessLogic
{
    public class HistoryCRUD
    {
        public static int MoveJobToHistory(string clientsEmail,
                                           string repairersEmail,
                                           string requestDescrption,
                                           Enums.JobOutcome outcome)
        {
            JobHistory data = new JobHistory
            {
                ClientsEmailAddress = clientsEmail,
                RepairersEmailAddress = repairersEmail,
                RequestDescription = requestDescrption,
                Outcome = outcome
            };

            string sql = @"INSERT INTO dbo.JobHistory (ClientsEmailAddress, RepairersEmailAddress, RequestDescription, Outcome)
                           VALUES (@ClientsEmailAddress, @RepairersEmailAddress, @RequestDescription, @Outcome);";

            return SSMSDataAccess.SaveData(sql, data);
        }
    }
}
