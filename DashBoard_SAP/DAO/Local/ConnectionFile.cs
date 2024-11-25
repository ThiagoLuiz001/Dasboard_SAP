using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;
using DashBoard_SAP.Models.Entities;
using DashBoard_SAP.Services;
using DashBoard_SAP.Models.Exceptions;
namespace DashBoard_SAP.DAO.Local
{
    public static class ConnectionFile
    {
        public static string _path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public static bool ExistsFile(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    return true;
                }
                return false;
            }
            catch
            {
                throw new ExceptionFiles($"Caminho de rquivo não encontrado {path}");
            }
        }
        





    }


}
