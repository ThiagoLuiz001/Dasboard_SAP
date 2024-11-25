using DashBoard_SAP.Models.Entities;
using DashBoard_SAP.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_SAP.DAO.Local
{
    public static class Report
    {
        static string path = ConnectionFile._path +@"\Files\Reports\";
        public static void CreationReport(Dictionary<string, HashSet<Production>> production)
        {
            try
            {
                foreach (var prod in production)
                {
                    if (ConnectionFile.ExistsFile(path + prod.Key) == false)
                    {
                         Directory.CreateDirectory(path + prod.Key);
                    }
                    else
                    {

                    }
                }
            }
            catch (ExceptionFiles ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void AddReport(HashSet<Production> production, string _path)
        {
            try
            {
                using (StreamReader sr = File.OpenText(_path))
                {
                    var list = new HashSet<Production>();
                    string line = "";
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        string[] txt = line.Split("|");
                        list.Add(new Production(txt[0], Double.Parse(txt[1]), Double.Parse(txt[2]), DateTime.Parse(txt[3])));
                    }
                        using (StreamWriter sw = File.AppendText(_path))
                    {
                        list.ExceptWith(production);
                        foreach (var prod in list)
                        {
                            sw.WriteLine(prod.ToString());
                        }
                    }
                }
            }catch(IOException ex)
            {
                MessageBox.Show(ex.Message + $" ({DateTime.Now.ToString("hh:mm dd/MM/yy")})");
            }
        }
    }
}
