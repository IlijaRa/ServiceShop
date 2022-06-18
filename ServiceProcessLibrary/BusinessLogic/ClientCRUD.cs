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

        public static List<string> LoadClientsEmails()
        {
            string sql = @"SELECT EmailAddress
                           FROM dbo.Client;";

            return SSMSDataAccess.LoadData<string>(sql);
        }

        public static Client LoadClientByEmail(string clientEmail)
        {
            string sql = @"SELECT *
                           FROM dbo.Client
                           WHERE EmailAddress = @EmailAddress;";

            return SSMSDataAccess.LoadClientByEmail<Client>(sql, clientEmail);
        }

    }
}
