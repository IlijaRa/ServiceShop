using ServiceProcessLibrary.DataAccess;
using ServiceProcessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProcessLibrary.BusinessLogic
{
    public class MaterialCRUD
    {
        public static List<Material> LoadMaterials()
        {
            string sql = @"SELECT *
                           FROM dbo.Material;";

            return SSMSDataAccess.LoadData<Material>(sql);
        }
    }
}
