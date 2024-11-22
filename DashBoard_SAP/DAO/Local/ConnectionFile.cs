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

namespace DashBoard_SAP.DAO.Local
{
    public class ConnectionFile
    {
        private string _path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public ConnectionFile() { }

        /// <summary>
        /// Procura os dados salvos da capacidade
        /// </summary>
        /// <returns></returns>
        public Dictionary<string,Production> SearchCapacity()
        {
            var search = new Dictionary<string,Production>();
            string filepath = _path + $@"\Files\storage.txt";
            try
            {
                using(StreamReader sr = File.OpenText(filepath))
                {
                    var p = new HashSet<Production>();
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] text = line.Split("|");
                        p.Add(new Production(text[0], Double.Parse(text[1]), Double.Parse(text[2]), (DateTime.Parse(text[3]))));
                    }
                    search = Consultation.ConferProductionFile(p);
                }
            }
            catch(IOException ex) 
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }

            return search;
        }


        public void SaveCapacity(Dictionary<string,Production> prod)
        {
            string filepath = _path + $@"\Files\storage.txt";
            try
            {
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    foreach (var p in prod)
                    {
                        sw.WriteLine(p.ToString());
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }
    }
}
