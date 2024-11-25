using Newtonsoft.Json;
using DashBoard_SAP.Models.Exceptions;
using System.Data;
using Microsoft.Data.SqlClient;
using DashBoard_SAP.Services;

namespace DashBoard_SAP.DAO.SSMS
{
    public class Connection
    {
        private static string SetConnectionString()
        {
            string connectionString ="";
            string jsonPath = "conection.json";
            if(File.Exists(jsonPath))
            {
                string jsonContent = File.ReadAllText(jsonPath);
                var config = JsonConvert.DeserializeObject<Dictionary<string,string>>(jsonContent);
                if(config.TryGetValue("Server", out string? source) && config.TryGetValue("Database", out string? catalog))
                {
                    string user = config["User Id"];
                    string password = config["Password"];
                    connectionString = $"Data Source ={source}; Initial Catalog={catalog}; User ID={user}; Password={password}; TrustServerCertificate=true";
                }
                else
                {
                    try
                    {
                        throw new ExceptionSSMS("Arquivo de configuração de conexão inválido!");
                    }
                    catch(Exception ex)
                    {
                        Variables.Logs.Add(ex.Data.ToString());
                    }
                }
            }
            else
            {
                throw new ExceptionSSMS("Arquivo de configuração não encontrado.");
            }
            return connectionString;
        }

        public static SqlConnection Connect()
        {
            string connectionString = SetConnectionString();
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public static void Execute(SqlCommand command)
        {
            using SqlConnection connection = Connect();
            command.Connection = connection;
            command.ExecuteNonQuery();
        }

        public static SqlDataReader Read(SqlCommand command)
        {
            using SqlConnection con = Connect();
            command.Connection = con;
            using SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
    }
}
