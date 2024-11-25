using DashBoard_SAP.Models.Entities;
using DashBoard_SAP.Services;
using DashBoard_SAP.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_SAP.DAO.Local
{
    public class Capacity
    {
        static string path = ConnectionFile._path + @"\Files\storage.txt";
        /// <summary>
        /// Procura os dados salvos da capacidade
        /// </summary>
        /// <returns></returns>
        public static void SearchCapacity()
        {
            if (ConnectionFile.ExistsFile(path))
            {
                try
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        var p = new HashSet<Production>();
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string[] text = line.Split("|");
                            p.Add(new Production(text[0], Double.Parse(text[1]), Double.Parse(text[2]), (DateTime.Parse(text[3]))));
                        }
                        Variables.Prod = Consultation.ConferProductionFile(p);
                    }
                }
                catch (IOException ex)
                {
                    Variables.Logs.Add(ex + $"({DateTime.Now.ToString("hh:mm dd/MM/yy")}");
                    MessageBox.Show($"Erro: {ex.Message}");
                }
                catch (ExceptionFiles ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        public static void SaveCapacity()
        {
            try
            {
                if (ConnectionFile.ExistsFile(path))
                {
                    try
                    {
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            foreach (var p in Variables.Prod)
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
            catch(ExceptionFiles ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
