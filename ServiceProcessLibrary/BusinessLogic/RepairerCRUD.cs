using ServiceProcessLibrary.DataAccess;
using ServiceProcessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.BusinessLogic
{
    public class RepairerCRUD
    {
        public static List<Repairer> LoadRepairers()
        {
            string sql = @"SELECT *
                           FROM dbo.Repairer;";

            return SSMSDataAccess.LoadData<Repairer>(sql);
        }
    }
}
