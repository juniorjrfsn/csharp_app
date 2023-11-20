using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.REPOSITORY
{
    public class Repository<T> where T : class
    {
        string connectionString = "Server=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\njunior\\Documents\\projetos\\C#APP\\Banco\\App_Data\\Database1.mdf;Integrated Security=True"; //providerName="System.Data.EntityClient" //ConfigurationManager.ConnectionStrings["LocalDB"].ConnectionString;

        

        public List<object> ExecutarSQL(string queryString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    List<object> dados = new List<object>();
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dados = dataTable.Select().ToList<object>();
                    connection.Close();

                    return dados;
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }
    }
}
