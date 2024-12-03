using DashBoard_SAP.Models.Entities;
using DashBoard_SAP.Services;
using DashBoard_SAP.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
//ARRUMAR ESSA PORCARIA
namespace DashBoard_SAP.DAO.Local
{
    public class Capacity
    {
        static string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Files";

        //______________________________________ARRUMAR
        /// <summary>
        /// Procura os dados salvos da capacidade
        /// </summary>
        /// <returns></returns>
        public static void SearchStorage()
        {
            var _path = path + @"\storage.tx";
            if (ConnectionFile.ExistsFile(_path))
            {
                try
                {
                    
                    using (StreamReader sr = File.OpenText(_path))
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
        //__________________________________ARRUMAE
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


        public static List<string>? LoadFiles()
        {
            var list= new List<string>(); 
            try
            {
                string _path = $@"{path}\Capacity";
                var files = Directory.EnumerateFiles(_path, ".", SearchOption.AllDirectories);
                foreach(var f in files)
                {
                    
                    list.Add(Path.GetFileNameWithoutExtension(f));
                }
                return list;
            }
            catch(IOException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            list.Add("N/A");
            return list;
        }
        public static void OpenFiles(string _path)
        {
            string openpath = $@"{path}\Capacity";
            try
            {
                if (ConnectionFile.ExistDirectory(openpath))
                {
                    openpath += openpath + @$"\{_path}.txt";
                    if (ConnectionFile.ExistsFile(openpath))
                    {

                    }
                }
            }
            catch
            {

            }
        }

    }


   
}
