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
    public class ConnectionFile
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




        private static bool ExistDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                return false;
            }
            return true;
        }




        public static void CreationFile (string path, string file)
        {
            string archive = Path.Combine(path, file) + ".txt";
            if (ExistDirectory(path))
            {
                if (ExistsFile(archive))
                {
                    MessageBox.Show("O arquivo de texto já existe.");
                }
                else
                {
                    using (FileStream cr = File.Create(archive))
                    {

                    }
                }
            }
            else
            {
                Directory.CreateDirectory(path);
                return;
            }
        }



    }


}
