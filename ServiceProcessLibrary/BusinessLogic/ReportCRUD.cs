using ServiceProcessLibrary.DataAccess;
using ServiceProcessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.BusinessLogic
{
    public class ReportCRUD
    {
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

        public static List<Report> LoadReports()
        {
            string sql = @"SELECT *
                           FROM dbo.Report;";

            return SSMSDataAccess.LoadData<Report>(sql);
        }
    }

}
