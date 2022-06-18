﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ServiceProcessLibrary.DataAccess
{
    public static class SSMSDataAccess
    {
        public static string GettConnectionstring(string connectionName = "ServiceProcess")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GettConnectionstring()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }

        public static T LoadSingleData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GettConnectionstring()))
            {
                return (T)cnn.Query(sql);
            }
        }

        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GettConnectionstring()))
            {
                return cnn.Execute(sql, data);
            }
        }
    }
}
