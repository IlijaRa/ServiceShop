using ServiceProcessLibrary.DataAccess;
using ServiceProcessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.BusinessLogic
{
    public class ClientCRUD
    {

        public static List<Client> LoadClients()
        {
            string sql = @"SELECT *
                           FROM dbo.Client;";

            return SSMSDataAccess.LoadData<Client>(sql);
        }
    }
}
